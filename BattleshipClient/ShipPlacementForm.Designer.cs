namespace BattleshipClient
{
    partial class ShipPlacementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.destroyerLetter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destoyerNumber = new System.Windows.Forms.TextBox();
            this.destroyerHoriz = new System.Windows.Forms.RadioButton();
            this.destroyerVert = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submarineNumber = new System.Windows.Forms.TextBox();
            this.submarineHoriz = new System.Windows.Forms.RadioButton();
            this.submarineVert = new System.Windows.Forms.RadioButton();
            this.submarineLetter = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cruiserNumber = new System.Windows.Forms.TextBox();
            this.cruiserHoriz = new System.Windows.Forms.RadioButton();
            this.cruiserVert = new System.Windows.Forms.RadioButton();
            this.cruiserLetter = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.battleshipNumber = new System.Windows.Forms.TextBox();
            this.battleshipHoriz = new System.Windows.Forms.RadioButton();
            this.battleshipVert = new System.Windows.Forms.RadioButton();
            this.battleshipLetter = new System.Windows.Forms.TextBox();
            this.placeShipsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ship Placement";
            // 
            // destroyerLetter
            // 
            this.destroyerLetter.Location = new System.Drawing.Point(6, 75);
            this.destroyerLetter.MaxLength = 1;
            this.destroyerLetter.Name = "destroyerLetter";
            this.destroyerLetter.Size = new System.Drawing.Size(39, 22);
            this.destroyerLetter.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Horizontal Coordinate is the left of ship";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Vertical Cordinate is the top of ship.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Letter then Number for coordinate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.destoyerNumber);
            this.groupBox1.Controls.Add(this.destroyerHoriz);
            this.groupBox1.Controls.Add(this.destroyerVert);
            this.groupBox1.Controls.Add(this.destroyerLetter);
            this.groupBox1.Location = new System.Drawing.Point(18, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 138);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destroyer (2x1)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "(0-9)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "(A-J)";
            // 
            // destoyerNumber
            // 
            this.destoyerNumber.Location = new System.Drawing.Point(6, 103);
            this.destoyerNumber.MaxLength = 2;
            this.destoyerNumber.Name = "destoyerNumber";
            this.destoyerNumber.Size = new System.Drawing.Size(39, 22);
            this.destoyerNumber.TabIndex = 10;
            // 
            // destroyerHoriz
            // 
            this.destroyerHoriz.AutoSize = true;
            this.destroyerHoriz.Location = new System.Drawing.Point(6, 48);
            this.destroyerHoriz.Name = "destroyerHoriz";
            this.destroyerHoriz.Size = new System.Drawing.Size(93, 21);
            this.destroyerHoriz.TabIndex = 9;
            this.destroyerHoriz.TabStop = true;
            this.destroyerHoriz.Text = "Horizontal";
            this.destroyerHoriz.UseVisualStyleBackColor = true;
            // 
            // destroyerVert
            // 
            this.destroyerVert.AutoSize = true;
            this.destroyerVert.Checked = true;
            this.destroyerVert.Location = new System.Drawing.Point(6, 21);
            this.destroyerVert.Name = "destroyerVert";
            this.destroyerVert.Size = new System.Drawing.Size(76, 21);
            this.destroyerVert.TabIndex = 8;
            this.destroyerVert.TabStop = true;
            this.destroyerVert.Text = "Vertical";
            this.destroyerVert.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.submarineNumber);
            this.groupBox2.Controls.Add(this.submarineHoriz);
            this.groupBox2.Controls.Add(this.submarineVert);
            this.groupBox2.Controls.Add(this.submarineLetter);
            this.groupBox2.Location = new System.Drawing.Point(148, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 138);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Submarine (3x1)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "(0-9)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "(A-J)";
            // 
            // submarineNumber
            // 
            this.submarineNumber.Location = new System.Drawing.Point(6, 103);
            this.submarineNumber.MaxLength = 2;
            this.submarineNumber.Name = "submarineNumber";
            this.submarineNumber.Size = new System.Drawing.Size(39, 22);
            this.submarineNumber.TabIndex = 10;
            // 
            // submarineHoriz
            // 
            this.submarineHoriz.AutoSize = true;
            this.submarineHoriz.Location = new System.Drawing.Point(6, 48);
            this.submarineHoriz.Name = "submarineHoriz";
            this.submarineHoriz.Size = new System.Drawing.Size(93, 21);
            this.submarineHoriz.TabIndex = 9;
            this.submarineHoriz.TabStop = true;
            this.submarineHoriz.Text = "Horizontal";
            this.submarineHoriz.UseVisualStyleBackColor = true;
            // 
            // submarineVert
            // 
            this.submarineVert.AutoSize = true;
            this.submarineVert.Checked = true;
            this.submarineVert.Location = new System.Drawing.Point(6, 21);
            this.submarineVert.Name = "submarineVert";
            this.submarineVert.Size = new System.Drawing.Size(76, 21);
            this.submarineVert.TabIndex = 8;
            this.submarineVert.TabStop = true;
            this.submarineVert.Text = "Vertical";
            this.submarineVert.UseVisualStyleBackColor = true;
            // 
            // submarineLetter
            // 
            this.submarineLetter.Location = new System.Drawing.Point(6, 75);
            this.submarineLetter.MaxLength = 1;
            this.submarineLetter.Name = "submarineLetter";
            this.submarineLetter.Size = new System.Drawing.Size(39, 22);
            this.submarineLetter.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cruiserNumber);
            this.groupBox3.Controls.Add(this.cruiserHoriz);
            this.groupBox3.Controls.Add(this.cruiserVert);
            this.groupBox3.Controls.Add(this.cruiserLetter);
            this.groupBox3.Location = new System.Drawing.Point(291, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 138);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cruiser (4x1)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "(0-9)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "(A-J)";
            // 
            // cruiserNumber
            // 
            this.cruiserNumber.Location = new System.Drawing.Point(6, 103);
            this.cruiserNumber.Name = "cruiserNumber";
            this.cruiserNumber.Size = new System.Drawing.Size(39, 22);
            this.cruiserNumber.TabIndex = 10;
            // 
            // cruiserHoriz
            // 
            this.cruiserHoriz.AutoSize = true;
            this.cruiserHoriz.Location = new System.Drawing.Point(6, 48);
            this.cruiserHoriz.Name = "cruiserHoriz";
            this.cruiserHoriz.Size = new System.Drawing.Size(93, 21);
            this.cruiserHoriz.TabIndex = 9;
            this.cruiserHoriz.TabStop = true;
            this.cruiserHoriz.Text = "Horizontal";
            this.cruiserHoriz.UseVisualStyleBackColor = true;
            // 
            // cruiserVert
            // 
            this.cruiserVert.AutoSize = true;
            this.cruiserVert.Checked = true;
            this.cruiserVert.Location = new System.Drawing.Point(6, 21);
            this.cruiserVert.Name = "cruiserVert";
            this.cruiserVert.Size = new System.Drawing.Size(76, 21);
            this.cruiserVert.TabIndex = 8;
            this.cruiserVert.TabStop = true;
            this.cruiserVert.Text = "Vertical";
            this.cruiserVert.UseVisualStyleBackColor = true;
            // 
            // cruiserLetter
            // 
            this.cruiserLetter.Location = new System.Drawing.Point(6, 75);
            this.cruiserLetter.Name = "cruiserLetter";
            this.cruiserLetter.Size = new System.Drawing.Size(39, 22);
            this.cruiserLetter.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.battleshipNumber);
            this.groupBox4.Controls.Add(this.battleshipHoriz);
            this.groupBox4.Controls.Add(this.battleshipVert);
            this.groupBox4.Controls.Add(this.battleshipLetter);
            this.groupBox4.Location = new System.Drawing.Point(421, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 138);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Battleship (5x1)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "(0-9)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "(A-J)";
            // 
            // battleshipNumber
            // 
            this.battleshipNumber.Location = new System.Drawing.Point(6, 103);
            this.battleshipNumber.MaxLength = 2;
            this.battleshipNumber.Name = "battleshipNumber";
            this.battleshipNumber.Size = new System.Drawing.Size(39, 22);
            this.battleshipNumber.TabIndex = 10;
            // 
            // battleshipHoriz
            // 
            this.battleshipHoriz.AutoSize = true;
            this.battleshipHoriz.Location = new System.Drawing.Point(6, 48);
            this.battleshipHoriz.Name = "battleshipHoriz";
            this.battleshipHoriz.Size = new System.Drawing.Size(93, 21);
            this.battleshipHoriz.TabIndex = 9;
            this.battleshipHoriz.TabStop = true;
            this.battleshipHoriz.Text = "Horizontal";
            this.battleshipHoriz.UseVisualStyleBackColor = true;
            // 
            // battleshipVert
            // 
            this.battleshipVert.AutoSize = true;
            this.battleshipVert.Checked = true;
            this.battleshipVert.Location = new System.Drawing.Point(6, 21);
            this.battleshipVert.Name = "battleshipVert";
            this.battleshipVert.Size = new System.Drawing.Size(76, 21);
            this.battleshipVert.TabIndex = 8;
            this.battleshipVert.TabStop = true;
            this.battleshipVert.Text = "Vertical";
            this.battleshipVert.UseVisualStyleBackColor = true;
            // 
            // battleshipLetter
            // 
            this.battleshipLetter.Location = new System.Drawing.Point(6, 75);
            this.battleshipLetter.MaxLength = 1;
            this.battleshipLetter.Name = "battleshipLetter";
            this.battleshipLetter.Size = new System.Drawing.Size(39, 22);
            this.battleshipLetter.TabIndex = 7;
            // 
            // placeShipsButton
            // 
            this.placeShipsButton.Location = new System.Drawing.Point(428, 259);
            this.placeShipsButton.Name = "placeShipsButton";
            this.placeShipsButton.Size = new System.Drawing.Size(117, 45);
            this.placeShipsButton.TabIndex = 24;
            this.placeShipsButton.Text = "Place Ships";
            this.placeShipsButton.UseVisualStyleBackColor = true;
            this.placeShipsButton.Click += new System.EventHandler(this.placeShipsButton_Click);
            // 
            // ShipPlacementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 320);
            this.Controls.Add(this.placeShipsButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShipPlacementForm";
            this.Text = "Ship Placement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destroyerLetter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton destroyerHoriz;
        private System.Windows.Forms.RadioButton destroyerVert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton submarineHoriz;
        private System.Windows.Forms.RadioButton submarineVert;
        private System.Windows.Forms.TextBox submarineLetter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton cruiserHoriz;
        private System.Windows.Forms.RadioButton cruiserVert;
        private System.Windows.Forms.TextBox cruiserLetter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton battleshipHoriz;
        private System.Windows.Forms.RadioButton battleshipVert;
        private System.Windows.Forms.TextBox battleshipLetter;
        private System.Windows.Forms.Button placeShipsButton;
        private System.Windows.Forms.TextBox destoyerNumber;
        private System.Windows.Forms.TextBox submarineNumber;
        private System.Windows.Forms.TextBox cruiserNumber;
        private System.Windows.Forms.TextBox battleshipNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
    }
}