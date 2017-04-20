namespace Assignment5
{
    partial class frmChooseGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseGame));
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnSubGame = new System.Windows.Forms.Button();
            this.btnMultGame = new System.Windows.Forms.Button();
            this.btnDivideGame = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddGame
            // 
            this.btnAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.btnAddGame.Location = new System.Drawing.Point(52, 446);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(222, 197);
            this.btnAddGame.TabIndex = 0;
            this.btnAddGame.Text = "+";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // btnSubGame
            // 
            this.btnSubGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.btnSubGame.Location = new System.Drawing.Point(356, 446);
            this.btnSubGame.Name = "btnSubGame";
            this.btnSubGame.Size = new System.Drawing.Size(222, 197);
            this.btnSubGame.TabIndex = 1;
            this.btnSubGame.Text = "-";
            this.btnSubGame.UseVisualStyleBackColor = true;
            this.btnSubGame.Click += new System.EventHandler(this.btnSubGame_Click);
            // 
            // btnMultGame
            // 
            this.btnMultGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.btnMultGame.Location = new System.Drawing.Point(675, 446);
            this.btnMultGame.Name = "btnMultGame";
            this.btnMultGame.Size = new System.Drawing.Size(222, 197);
            this.btnMultGame.TabIndex = 2;
            this.btnMultGame.Text = "x";
            this.btnMultGame.UseVisualStyleBackColor = true;
            this.btnMultGame.Click += new System.EventHandler(this.btnMultGame_Click);
            // 
            // btnDivideGame
            // 
            this.btnDivideGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.btnDivideGame.Location = new System.Drawing.Point(977, 446);
            this.btnDivideGame.Name = "btnDivideGame";
            this.btnDivideGame.Size = new System.Drawing.Size(222, 197);
            this.btnDivideGame.TabIndex = 3;
            this.btnDivideGame.Text = "/";
            this.btnDivideGame.UseVisualStyleBackColor = true;
            this.btnDivideGame.Click += new System.EventHandler(this.btnDivideGame_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnReturn.Location = new System.Drawing.Point(1028, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(222, 114);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return to the Castle";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmChooseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDivideGame);
            this.Controls.Add(this.btnMultGame);
            this.Controls.Add(this.btnSubGame);
            this.Controls.Add(this.btnAddGame);
            this.Name = "frmChooseGame";
            this.Text = "frmChooseGame";
            this.Load += new System.EventHandler(this.frmChooseGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnSubGame;
        private System.Windows.Forms.Button btnMultGame;
        private System.Windows.Forms.Button btnDivideGame;
        private System.Windows.Forms.Button btnReturn;
    }
}