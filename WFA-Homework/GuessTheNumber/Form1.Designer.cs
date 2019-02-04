namespace GuessTheNumber
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
            this.cmLevel = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbUserNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.pbLikes = new System.Windows.Forms.PictureBox();
            this.pbPoints = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // cmLevel
            // 
            this.cmLevel.FormattingEnabled = true;
            this.cmLevel.Items.AddRange(new object[] {
            "1-10",
            "1-50",
            "1-100",
            "1-1000"});
            this.cmLevel.Location = new System.Drawing.Point(50, 50);
            this.cmLevel.Name = "cmLevel";
            this.cmLevel.Size = new System.Drawing.Size(121, 24);
            this.cmLevel.TabIndex = 0;
            this.cmLevel.SelectedIndexChanged += new System.EventHandler(this.cmLevel_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(264, 39);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(162, 70);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tbUserNumber
            // 
            this.tbUserNumber.Location = new System.Drawing.Point(50, 199);
            this.tbUserNumber.Name = "tbUserNumber";
            this.tbUserNumber.Size = new System.Drawing.Size(75, 22);
            this.tbUserNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Guess the random number";
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Location = new System.Drawing.Point(47, 339);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(46, 17);
            this.lblTries.TabIndex = 6;
            this.lblTries.Text = "label3";
            // 
            // pbLikes
            // 
            this.pbLikes.Image = global::GuessTheNumber.Properties.Resources.thumb_up_to_like_on_facebook_318_37196;
            this.pbLikes.Location = new System.Drawing.Point(251, 286);
            this.pbLikes.Name = "pbLikes";
            this.pbLikes.Size = new System.Drawing.Size(175, 152);
            this.pbLikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLikes.TabIndex = 7;
            this.pbLikes.TabStop = false;
            // 
            // pbPoints
            // 
            this.pbPoints.Image = global::GuessTheNumber.Properties.Resources.download;
            this.pbPoints.Location = new System.Drawing.Point(251, 176);
            this.pbPoints.Name = "pbPoints";
            this.pbPoints.Size = new System.Drawing.Size(72, 66);
            this.pbPoints.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoints.TabIndex = 3;
            this.pbPoints.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.pbLikes);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPoints);
            this.Controls.Add(this.tbUserNumber);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cmLevel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmLevel;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox tbUserNumber;
        private System.Windows.Forms.PictureBox pbPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.PictureBox pbLikes;
    }
}

