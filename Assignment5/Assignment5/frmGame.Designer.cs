namespace Assignment5
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnBeginGame = new System.Windows.Forms.Button();
            this.lblEquals = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.picKnight = new System.Windows.Forms.PictureBox();
            this.imageListDragon = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxDragon = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDragon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lblNum1.Location = new System.Drawing.Point(11, 136);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(0, 189);
            this.lblNum1.TabIndex = 0;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.BackColor = System.Drawing.Color.Transparent;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lblOperation.Location = new System.Drawing.Point(260, 136);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(178, 189);
            this.lblOperation.TabIndex = 1;
            this.lblOperation.Text = "+";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lblNum2.Location = new System.Drawing.Point(421, 136);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(0, 189);
            this.lblNum2.TabIndex = 2;
            // 
            // btnBeginGame
            // 
            this.btnBeginGame.Location = new System.Drawing.Point(58, 48);
            this.btnBeginGame.Name = "btnBeginGame";
            this.btnBeginGame.Size = new System.Drawing.Size(125, 45);
            this.btnBeginGame.TabIndex = 3;
            this.btnBeginGame.Text = "Begin Game";
            this.btnBeginGame.UseVisualStyleBackColor = true;
            this.btnBeginGame.Click += new System.EventHandler(this.btnBeginGame_Click);
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.BackColor = System.Drawing.Color.Transparent;
            this.lblEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lblEquals.Location = new System.Drawing.Point(662, 143);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(178, 189);
            this.lblEquals.TabIndex = 4;
            this.lblEquals.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F);
            this.txtAnswer.Location = new System.Drawing.Point(798, 136);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(273, 177);
            this.txtAnswer.TabIndex = 5;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCorrect.Location = new System.Drawing.Point(374, 54);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(163, 39);
            this.lblCorrect.TabIndex = 6;
            this.lblCorrect.Text = "lblCorrect";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1084, 143);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 158);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblTimer.Location = new System.Drawing.Point(976, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(87, 95);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "0";
            // 
            // picKnight
            // 
            this.picKnight.BackColor = System.Drawing.Color.Transparent;
            this.picKnight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picKnight.Image = ((System.Drawing.Image)(resources.GetObject("picKnight.Image")));
            this.picKnight.Location = new System.Drawing.Point(43, 378);
            this.picKnight.Name = "picKnight";
            this.picKnight.Size = new System.Drawing.Size(275, 247);
            this.picKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKnight.TabIndex = 9;
            this.picKnight.TabStop = false;
            // 
            // imageListDragon
            // 
            this.imageListDragon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDragon.ImageStream")));
            this.imageListDragon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDragon.Images.SetKeyName(0, "Dragon-01.png");
            this.imageListDragon.Images.SetKeyName(1, "Dragon Dead-01.png");
            // 
            // pictureBoxDragon
            // 
            this.pictureBoxDragon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxDragon.Location = new System.Drawing.Point(895, 352);
            this.pictureBoxDragon.Name = "pictureBoxDragon";
            this.pictureBoxDragon.Size = new System.Drawing.Size(294, 273);
            this.pictureBoxDragon.TabIndex = 10;
            this.pictureBoxDragon.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnReturn.Location = new System.Drawing.Point(819, 119);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(214, 202);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return to battle!";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTotal.Location = new System.Drawing.Point(82, 111);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(625, 248);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(719, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 95);
            this.label1.TabIndex = 13;
            this.label1.Text = "Time:";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pictureBoxDragon);
            this.Controls.Add(this.picKnight);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.btnBeginGame);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblNum1);
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDragon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnBeginGame;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox picKnight;
        private System.Windows.Forms.ImageList imageListDragon;
        private System.Windows.Forms.PictureBox pictureBoxDragon;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}