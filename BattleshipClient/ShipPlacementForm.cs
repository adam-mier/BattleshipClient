using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipClient
{
    public partial class ShipPlacementForm : Form
    {
        private Form1 parent;
        private bool error = false;
        private int[] tempGrid = new int[100];


        public ShipPlacementForm(Form1 parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            for (int i = 0; i < 100; i++)
                tempGrid[i] = 0;
        }

        private void placeShipsButton_Click(object sender, EventArgs e)
        {
            if (destroyerLetter.Text != "" && cruiserLetter.Text != "" 
                && submarineLetter.Text != "" && battleshipLetter.Text != ""
                && destoyerNumber.Text != "" && cruiserNumber.Text != ""
                && submarineNumber.Text != "" && battleshipNumber.Text != "")
            {
                BeginCheckPlacement();   
                if (!error) //no error when placing in temp grid
                {
                    for (int i=0; i < 100; i++)
                    {
                        parent.myGrid[i] = tempGrid[i]; //hard copy to parent's grid
                        ChangeColorOfShips();
                    }
                    // finished being placed
                    parent.shipsPlaced = true;
                    parent.writer.WriteLineAsync("READY"); parent.writer.Flush();
                    Close(); //close ship placement form
                }
                else
                {
                    error = false;
                    MessageBox.Show("Error occured placing ships. Check coordinates for overlapping.");
                }
            }
            else
            {
                MessageBox.Show("All coordinates are required!");
            }
        }

        private void BeginCheckPlacement()
        {
            // [DONE]
            #region battleship 5x1
            // battleship (5x1) :: 51
            var isVert = battleshipVert.Checked;
            var index = getIndex(battleshipLetter.Text, battleshipNumber.Text);
            if (index < 0)
            {
                error = true;
            }
            else
            {
                if (isVert)
                {
                    // VERTICAL PLACEMENT
                    if (index > 59) //cannot be placed on 6th row down because it goes off grid
                    {
                        error = true;
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++) // can place since its first ship
                        {
                            tempGrid[index + (i * 10)] = 51;
                        }
                    }
                }
                else
                {
                    // HORIZONTAL PLACEMENT
                    var temp = index.ToString();
                    var check = temp.Length == 1 ? char.Parse(temp) : temp[1]; // Second digit checks horizontal depth
                    if ((check == '6' || check == '7' || check == '8' || check == '9')) // cannot be placed on 6th row across because off grid
                    {
                        error = true;
                    }
                    else
                    {
                        for (int i = 0; i<5; i++)
                        {
                            tempGrid[index + i] = 51;
                        }
                    }
                }
            }
            #endregion

            // [DONE]
            #region cruiser 4x1
            if (!error)
            {
                var cVert = cruiserVert.Checked;
                var cIndex = getIndex(cruiserLetter.Text, cruiserNumber.Text);
                if (cIndex < 0) error = true;
                else
                {
                    if (cVert)
                    {
                        // vertical
                        //check if in grid
                        if (cIndex > 69) error = true;
                        else
                        {
                            // check for ships
                            for (int i = 0; i < 4; i++)
                            {
                                if (tempGrid[cIndex + (i * 10)] > 0) error = true;
                            }
                            if (!error) //no overlapping ships so far
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    tempGrid[cIndex + (i * 10)] = 41; //place since free
                                }
                            }
                        }
                    }
                    else
                    {
                        // horizontal
                        //check if in grid
                        var temp = cIndex.ToString();
                        var check = temp.Length == 1 ? char.Parse(temp) : temp[1]; // Second digit checks horizontal depth
                        if (check == '7' || check == '8' || check == '9') error = true; 
                        else
                        {
                            // check for ships
                            for (int i = 0; i < 4; i++)
                            {
                                if (tempGrid[cIndex + i] > 0) error = true; //ship found on grid
                            }
                            if (!error)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    tempGrid[cIndex + i] = 41; //place 
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            // [DONE]
            #region submarine 3x1
            if (!error)
            {
                var sVert = submarineVert.Checked;
                var sIndex = getIndex(submarineLetter.Text, submarineNumber.Text);
                if (sIndex < 0) error = true;
                else
                {
                    if (sVert)
                    {
                        // VERTICAL PLACEMENT
                        //check for in grid
                        if (sIndex > 79) error = true;
                        else
                        {
                            // check for ships
                            for (int i = 0; i < 3; i++)
                            {
                                if (tempGrid[sIndex + (i * 10)] > 0) error = true; //ship found
                            }
                            if (!error)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    tempGrid[sIndex + (i * 10)] = 31; //place ships
                                }
                            }
                        }
                    }
                    else
                    {
                        // HORIZONTAL PLACEMENT
                        var temp = sIndex.ToString();
                        var check = temp.Length == 1 ? char.Parse(temp) : temp[1]; // Second digit checks horizontal depth
                        if (check == '8' || check == '9') error = true;
                        else
                        {
                            // check for ships
                            for (int i = 0; i < 3; i++)
                            {
                                if (tempGrid[sIndex + i] > 0) error = true;
                            }
                            if (!error)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    tempGrid[sIndex + i] = 31; //place
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region destroyer
            if (!error)
            {
                var dVert = destroyerVert.Checked;
                var dIndex = getIndex(destroyerLetter.Text, destoyerNumber.Text);
                if (dIndex < 0) error = true;
                else
                {
                    if (dVert)
                    {
                        // VERTICAL PLACEMENT
                        //check if in grid
                        if (dIndex > 89) error = true;
                        else
                        {
                            // check for ships
                            for (int i = 0; i < 2; i++)
                            {
                                if (tempGrid[dIndex + (i * 10)] > 0) error = true; //ship found
                            }
                            if (!error)
                            {
                                for (int i=0; i<2; i++)
                                {
                                    tempGrid[dIndex + (i * 10)] = 21; //place ship
                                }
                            }
                        }
                    }
                    else
                    {
                        // HORIZONTAL PLACEMENT
                        var temp = dIndex.ToString();
                        var check = temp.Length == 1 ? char.Parse(temp) : temp[1]; // Second digit checks horizontal depth
                        if (check == '9') error = true;
                        else
                        {
                            // check for ships
                            for (int i = 0; i < 2; i++)
                            {
                                if (tempGrid[dIndex + i] > 0) error = true; //ship found
                            }
                            if (!error)
                            {
                                for (int i=0; i< 2; i++)
                                {
                                    tempGrid[dIndex + i] = 21;
                                }
                            }
                        }
                    }
                }
            }
            #endregion
        }

        // get array index of coordinate entered
        private int getIndex(string letter, string num)
        {
            var index = 0;
            switch (letter.ToUpper())
            {
                case "A": index = 0; break;
                case "B": index += 1; break;
                case "C": index += 2; break;
                case "D": index += 3; break;
                case "E": index += 4; break;
                case "F": index += 5; break;
                case "G": index += 6; break;
                case "H": index += 7; break;
                case "I": index += 8; break;
                case "J": index += 9; break;
                default:  index = -100;  break;
            }
            var numCoord = int.Parse(num);
            index += (numCoord * 10);
            return index;
        }

        private void ChangeColorOfShips()
        {
            // Get all buttons on form
            List<Control> buttons = new List<Control>();
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    buttons.Add(c);
                }
            }
            
            for (int i=0; i<100; i++) 
            {
                if (tempGrid[i] > 0)
                {
                    foreach (var button in buttons)
                    {
                        var temp = 100 + i;
                        if (button.Name.Contains(temp.ToString()))
                        {
                            button.BackColor = System.Drawing.Color.Gray;
                            switch (tempGrid[i])
                            {
                                case 51: button.Text = "B"; break;
                                case 41: button.Text = "C"; break;
                                case 31: button.Text = "S"; break;
                                case 21: button.Text = "D"; break;
                                default: button.Text = ""; break;
                            }
                        }
                    }
                }
            }
        }
    }
}
