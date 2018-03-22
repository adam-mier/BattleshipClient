using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipClient
{
    public partial class Form1 : Form
    {
        public int playerNum; // Player's number
        public int myAtkIndex; // This client's attack index
        public bool canAttack = false;
        public bool shipsPlaced = false;
        public int[] enemyGrid = new int[100]; // 0=no event; 1=miss; 2=hit
        public int[] myGrid = new int[100]; // 0=no event; 1=miss; 2=hit; 21=destroyer; 31=submarine; 41=cruiser; 51=battleship
        private TcpClient client;
        public StreamWriter writer;
        public StreamReader reader;

        public Form1()
        {
            InitializeComponent();

            // initialize all grid to 0
            for (var i = 0; i < 100; i++)
            {
                enemyGrid[i] = 0;
                myGrid[i] = 0;
            }
        }

        // Once user types ip and connects to a server
        private void connectButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            if (inputIpTextBox.Text != null && inputIpTextBox.Text != "")
            {
                string stringIp = inputIpTextBox.Text;
                // 127.0.0.1 = localhost
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse(stringIp), 1337);
                try
                {
                    client.Connect(ip);
                    if (client.Connected)
                    {
                        writer = new StreamWriter(client.GetStream());
                        reader = new StreamReader(client.GetStream());
                        // Get Which Player this client is
                        var player = reader.ReadLine();
                        playerNum = int.Parse(player);
                        MessageBox.Show("You are player " + playerNum);
                        AppendTextBox("You are player " + playerNum + "\n");
                        // Disable all connect button prompt
                        playerNumDisplay.Text = "Player " + playerNum;
                        if (playerNum == 1) canAttack = true;
                        connectButton.Enabled = false;
                        connectIpLabel.Enabled = false;
                        inputIpTextBox.Enabled = false;

                        // Do ship placement algorithm
                        BeginShipPlacement();
                        backgroundWorker1.RunWorkerAsync(); //Begin Worker
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Server not available.");
                }
            }
            else
            {
                MessageBox.Show("IP Address required.");
            }
        }

        private void sendAttackCoordinate(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                if (canAttack && shipsPlaced) // If all ships are placed AND its your turn to attack
                {
                    var newSender = sender as Button; //cast to button
                    var name = newSender.Name;
                    name = name.Replace("button", "");
                    myAtkIndex = int.Parse(name);
                    writer.WriteLineAsync(name);
                    writer.Flush();
                    newSender.Enabled = false;
                }
                else
                {
                    MessageBox.Show("It is not your turn.");
                }
            }
            else
            {
                MessageBox.Show("Not connected to server.");
            }
        }

        // Runs after connection
        private void backgroundWorker1_doWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try {
                    var playerTurn = int.Parse(reader.ReadLine());
                    var index = 0;
                    if (playerTurn == playerNum) //you atk
                    {
                        canAttack = true;

                        // Status
                        var status = reader.ReadLine();
                        ChangeColorGrid("ENEMY", status, myAtkIndex);
                        //MessageBox.Show("Player " + playerTurn + "'s attack: " + status);
                        AppendTextBox("Player " + playerTurn + "'s attack: " + status + "\n");
                        myAtkIndex = 0; //reset
                    }
                    else //get atk'd
                    {
                        canAttack = false;
                        var oppAtk = reader.ReadLine(); // opponent's atk
                        index = int.Parse(oppAtk);
                        var isHit = CheckIndexForShip(index);
                        var tempPlayer = playerTurn == 1 ? 2 : 1;
                        if (!isHit) //miss
                        {
                            ChangeColorGrid("MY", "MISS", index); //change myGrid
                            writer.WriteLineAsync("MISS"); writer.Flush(); //server status notification to pop up
                            // Status
                            var status = reader.ReadLine();
                            tempPlayer = playerNum == 1 ? 2 : 1;
                            //MessageBox.Show("Player " + tempPlayer + "'s attack: " + status);
                            AppendTextBox("Player " + tempPlayer + "'s attack: " + status + "\n");
                        }
                        else //hit
                        {
                            ChangeColorGrid("MY", "HIT", index);
                            writer.WriteLineAsync("HIT"); writer.Flush();

                            //TODO:
                            // change enemy grid red
                            //if sunk, send hey you sunk
                            //else hit

                            // Status
                            var status = reader.ReadLine();
                            tempPlayer = playerNum == 1 ? 2 : 1;
                            //MessageBox.Show("Player " + tempPlayer + "'s attack: " + status);
                            AppendTextBox("Player " + tempPlayer + "'s attack: " + status + "\n");
                        }
                    }
                }
                catch (Exception ea)
                {
                    MessageBox.Show("Disconnected");
                }
            }
        }

        private void ChangeColorGrid(string type, string status, int index)
        {
            type = type.ToUpper();
            if (type == "MY")
            {
                // change myGrid color based on status
                if (status == "HIT")
                {
                    // index + 100
                    DoColorChange(System.Drawing.Color.Red, index + 100);
                }
                else if (status == "MISS")
                {
                    DoColorChange(System.Drawing.Color.White, index + 100);
                }
            }
            else if (type == "ENEMY")
            {
                // change enemyGrid color based on status
                if (status == "HIT")
                {
                    DoColorChange(System.Drawing.Color.Red, index);
                }
                else if (status == "MISS")
                {
                    DoColorChange(System.Drawing.Color.White, index);
                }
            }
        }

        private void DoColorChange(System.Drawing.Color color, int index)
        {
            List<Control> buttons = new List<Control>();
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button)) buttons.Add(c);
            }

            string bName = "button" + index;
            foreach (var b in buttons)
            {
                if (b.Name == bName)
                {
                    b.BackColor = color;
                }
            }
        }

        private bool CheckIndexForShip(int index)
        {
            return myGrid[index] > 20; //greater than 20 == ship
        }

        private void BeginShipPlacement()
        {
            ShipPlacementForm spf = new ShipPlacementForm(this);
            spf.Show();
        }

        private void AppendTextBox(string msg)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { msg });
                return;
            }
            eventsTextBox.AppendText(msg);
        }
    }
}
