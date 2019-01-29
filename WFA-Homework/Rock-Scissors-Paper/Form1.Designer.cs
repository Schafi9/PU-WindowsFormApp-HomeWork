namespace Rock_Scissors_Paper
{
    partial class Form1
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
            this.pbScissors = new System.Windows.Forms.PictureBox();
            this.pbRock = new System.Windows.Forms.PictureBox();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbPaper = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // pbScissors
            // 
            this.pbScissors.BackgroundImage = global::Rock_Scissors_Paper.Properties.Resources._004224_1;
            this.pbScissors.Image = global::Rock_Scissors_Paper.Properties.Resources._004224_1;
            this.pbScissors.Location = new System.Drawing.Point(205, 305);
            this.pbScissors.Name = "pbScissors";
            this.pbScissors.Size = new System.Drawing.Size(142, 133);
            this.pbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScissors.TabIndex = 0;
            this.pbScissors.TabStop = false;
            this.pbScissors.Click += new System.EventHandler(this.pbScissors_Click_1);
            // 
            // pbRock
            // 
            this.pbRock.BackgroundImage = global::Rock_Scissors_Paper.Properties.Resources.download;
            this.pbRock.Image = global::Rock_Scissors_Paper.Properties.Resources.download;
            this.pbRock.Location = new System.Drawing.Point(57, 305);
            this.pbRock.Name = "pbRock";
            this.pbRock.Size = new System.Drawing.Size(142, 133);
            this.pbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRock.TabIndex = 1;
            this.pbRock.TabStop = false;
            this.pbRock.Click += new System.EventHandler(this.pbRock_Click_1);
            // 
            // pbComputer
            // 
            this.pbComputer.Location = new System.Drawing.Point(629, 102);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(142, 133);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComputer.TabIndex = 2;
            this.pbComputer.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Location = new System.Drawing.Point(57, 102);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(142, 133);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 3;
            this.pbUser.TabStop = false;
            // 
            // pbPaper
            // 
            this.pbPaper.BackgroundImage = global::Rock_Scissors_Paper.Properties.Resources._61XMr2MDNtL__SY355_;
            this.pbPaper.Image = global::Rock_Scissors_Paper.Properties.Resources._61XMr2MDNtL__SY355_;
            this.pbPaper.Location = new System.Drawing.Point(353, 305);
            this.pbPaper.Name = "pbPaper";
            this.pbPaper.Size = new System.Drawing.Size(142, 133);
            this.pbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPaper.TabIndex = 4;
            this.pbPaper.TabStop = false;
            this.pbPaper.Click += new System.EventHandler(this.pbPaper_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "YOU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose your picture:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(318, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 60);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(501, 305);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(270, 68);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(501, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(270, 59);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(348, 225);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(82, 29);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(348, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPaper);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.pbRock);
            this.Controls.Add(this.pbScissors);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScissors;
        private System.Windows.Forms.PictureBox pbRock;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label5;
    }
}

