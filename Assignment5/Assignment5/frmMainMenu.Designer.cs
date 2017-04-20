namespace Assignment5
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnUserData = new System.Windows.Forms.Button();
            this.imageListTreasure = new System.Windows.Forms.ImageList(this.components);
            this.btnGame = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUserData
            // 
            this.btnUserData.BackColor = System.Drawing.Color.Transparent;
            this.btnUserData.FlatAppearance.BorderSize = 0;
            this.btnUserData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUserData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUserData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserData.ImageIndex = 0;
            this.btnUserData.ImageList = this.imageListTreasure;
            this.btnUserData.Location = new System.Drawing.Point(149, 375);
            this.btnUserData.Name = "btnUserData";
            this.btnUserData.Size = new System.Drawing.Size(306, 248);
            this.btnUserData.TabIndex = 0;
            this.btnUserData.Text = "Enter Player Data";
            this.btnUserData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserData.UseVisualStyleBackColor = false;
            this.btnUserData.Click += new System.EventHandler(this.btnUserData_Click);
            this.btnUserData.MouseLeave += new System.EventHandler(this.btnUserData_MouseLeave_1);
            this.btnUserData.MouseHover += new System.EventHandler(this.btnUserData_MouseHover);
            // 
            // imageListTreasure
            // 
            this.imageListTreasure.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreasure.ImageStream")));
            this.imageListTreasure.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreasure.Images.SetKeyName(0, "Chestclosed-01.png");
            this.imageListTreasure.Images.SetKeyName(1, "Chestopen-01.png");
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Transparent;
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGame.ImageIndex = 0;
            this.btnGame.ImageList = this.imageListTreasure;
            this.btnGame.Location = new System.Drawing.Point(510, 375);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(306, 248);
            this.btnGame.TabIndex = 1;
            this.btnGame.Text = "Play the Game!";
            this.btnGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            this.btnGame.MouseLeave += new System.EventHandler(this.btnGame_MouseLeave);
            this.btnGame.MouseHover += new System.EventHandler(this.btnGame_MouseHover);
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.Transparent;
            this.btnScores.FlatAppearance.BorderSize = 0;
            this.btnScores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnScores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnScores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScores.ImageIndex = 0;
            this.btnScores.ImageList = this.imageListTreasure;
            this.btnScores.Location = new System.Drawing.Point(872, 375);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(306, 248);
            this.btnScores.TabIndex = 2;
            this.btnScores.Text = "View Scores";
            this.btnScores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            this.btnScores.MouseLeave += new System.EventHandler(this.btnScores_MouseLeave);
            this.btnScores.MouseHover += new System.EventHandler(this.btnScores_MouseHover);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblWelcome.Location = new System.Drawing.Point(535, 177);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(252, 39);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome Label";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblError.Location = new System.Drawing.Point(582, 626);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(165, 17);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Please Enter your Player";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnUserData);
            this.Name = "frmMainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserData;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ImageList imageListTreasure;
        private System.Windows.Forms.Label lblError;
    }
}

