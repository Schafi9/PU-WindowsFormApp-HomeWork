namespace ConfigureMyAuto
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
            this.rbAudi = new System.Windows.Forms.RadioButton();
            this.rbBMW = new System.Windows.Forms.RadioButton();
            this.rbMercedes = new System.Windows.Forms.RadioButton();
            this.pbCars = new System.Windows.Forms.PictureBox();
            this.cbABS = new System.Windows.Forms.CheckBox();
            this.cbFog = new System.Windows.Forms.CheckBox();
            this.cbParktronik = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCarPrice = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFinalPrice = new System.Windows.Forms.TextBox();
            this.btnFinalPrice = new System.Windows.Forms.Button();
            this.cbCreditCard = new System.Windows.Forms.CheckBox();
            this.cbCheck = new System.Windows.Forms.CheckBox();
            this.cbCash = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCars)).BeginInit();
            this.SuspendLayout();
            // 
            // rbAudi
            // 
            this.rbAudi.AutoSize = true;
            this.rbAudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAudi.Location = new System.Drawing.Point(42, 61);
            this.rbAudi.Name = "rbAudi";
            this.rbAudi.Size = new System.Drawing.Size(57, 22);
            this.rbAudi.TabIndex = 0;
            this.rbAudi.TabStop = true;
            this.rbAudi.Text = "Audi";
            this.rbAudi.UseVisualStyleBackColor = true;
            this.rbAudi.CheckedChanged += new System.EventHandler(this.rbAudi_CheckedChanged);
            // 
            // rbBMW
            // 
            this.rbBMW.AutoSize = true;
            this.rbBMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBMW.Location = new System.Drawing.Point(42, 88);
            this.rbBMW.Name = "rbBMW";
            this.rbBMW.Size = new System.Drawing.Size(67, 22);
            this.rbBMW.TabIndex = 1;
            this.rbBMW.TabStop = true;
            this.rbBMW.Text = "BMW";
            this.rbBMW.UseVisualStyleBackColor = true;
            this.rbBMW.CheckedChanged += new System.EventHandler(this.rbBMW_CheckedChanged);
            // 
            // rbMercedes
            // 
            this.rbMercedes.AutoSize = true;
            this.rbMercedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMercedes.Location = new System.Drawing.Point(42, 115);
            this.rbMercedes.Name = "rbMercedes";
            this.rbMercedes.Size = new System.Drawing.Size(95, 22);
            this.rbMercedes.TabIndex = 2;
            this.rbMercedes.TabStop = true;
            this.rbMercedes.Text = "Mercedes";
            this.rbMercedes.UseVisualStyleBackColor = true;
            this.rbMercedes.CheckedChanged += new System.EventHandler(this.rbMercedes_CheckedChanged);
            // 
            // pbCars
            // 
            this.pbCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCars.Image = global::ConfigureMyAuto.Properties.Resources.mercedes;
            this.pbCars.Location = new System.Drawing.Point(242, 29);
            this.pbCars.Name = "pbCars";
            this.pbCars.Size = new System.Drawing.Size(555, 305);
            this.pbCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCars.TabIndex = 3;
            this.pbCars.TabStop = false;
            // 
            // cbABS
            // 
            this.cbABS.AutoSize = true;
            this.cbABS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbABS.Location = new System.Drawing.Point(42, 233);
            this.cbABS.Name = "cbABS";
            this.cbABS.Size = new System.Drawing.Size(62, 22);
            this.cbABS.TabIndex = 4;
            this.cbABS.Text = "ABS";
            this.cbABS.UseVisualStyleBackColor = true;
            this.cbABS.CheckedChanged += new System.EventHandler(this.cbABS_CheckedChanged);
            // 
            // cbFog
            // 
            this.cbFog.AutoSize = true;
            this.cbFog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFog.Location = new System.Drawing.Point(42, 260);
            this.cbFog.Name = "cbFog";
            this.cbFog.Size = new System.Drawing.Size(169, 22);
            this.cbFog.TabIndex = 5;
            this.cbFog.Text = "Extra lights for fog";
            this.cbFog.UseVisualStyleBackColor = true;
            this.cbFog.CheckedChanged += new System.EventHandler(this.cbFog_CheckedChanged);
            // 
            // cbParktronik
            // 
            this.cbParktronik.AutoSize = true;
            this.cbParktronik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbParktronik.Location = new System.Drawing.Point(42, 287);
            this.cbParktronik.Name = "cbParktronik";
            this.cbParktronik.Size = new System.Drawing.Size(108, 22);
            this.cbParktronik.TabIndex = 6;
            this.cbParktronik.Text = "Parktronik";
            this.cbParktronik.UseVisualStyleBackColor = true;
            this.cbParktronik.CheckedChanged += new System.EventHandler(this.cbParktronik_CheckedChanged);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiscount.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDiscount.Location = new System.Drawing.Point(452, 388);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(162, 50);
            this.btnDiscount.TabIndex = 8;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(12, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 50);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(620, 388);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(162, 50);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.Color.Blue;
            this.btnReset.Location = new System.Drawing.Point(116, 388);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 50);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Extra Adds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(270, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Car Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(626, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Discount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(447, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Price:";
            // 
            // tbCarPrice
            // 
            this.tbCarPrice.Location = new System.Drawing.Point(371, 356);
            this.tbCarPrice.Name = "tbCarPrice";
            this.tbCarPrice.ReadOnly = true;
            this.tbCarPrice.Size = new System.Drawing.Size(71, 22);
            this.tbCarPrice.TabIndex = 17;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(552, 356);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(68, 22);
            this.tbTotal.TabIndex = 18;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(715, 355);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.ReadOnly = true;
            this.tbDiscount.Size = new System.Drawing.Size(66, 22);
            this.tbDiscount.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Turquoise;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(803, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "How do you want to pay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(803, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Final Price:";
            // 
            // tbFinalPrice
            // 
            this.tbFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFinalPrice.Location = new System.Drawing.Point(808, 388);
            this.tbFinalPrice.Name = "tbFinalPrice";
            this.tbFinalPrice.ReadOnly = true;
            this.tbFinalPrice.Size = new System.Drawing.Size(276, 34);
            this.tbFinalPrice.TabIndex = 25;
            // 
            // btnFinalPrice
            // 
            this.btnFinalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinalPrice.Location = new System.Drawing.Point(808, 284);
            this.btnFinalPrice.Name = "btnFinalPrice";
            this.btnFinalPrice.Size = new System.Drawing.Size(162, 50);
            this.btnFinalPrice.TabIndex = 26;
            this.btnFinalPrice.Text = "Final Price";
            this.btnFinalPrice.UseVisualStyleBackColor = false;
            this.btnFinalPrice.Click += new System.EventHandler(this.btnFinalPrice_Click);
            // 
            // cbCreditCard
            // 
            this.cbCreditCard.AutoSize = true;
            this.cbCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCreditCard.Location = new System.Drawing.Point(823, 88);
            this.cbCreditCard.Name = "cbCreditCard";
            this.cbCreditCard.Size = new System.Drawing.Size(116, 22);
            this.cbCreditCard.TabIndex = 27;
            this.cbCreditCard.Text = "Credit Card";
            this.cbCreditCard.UseVisualStyleBackColor = true;
            // 
            // cbCheck
            // 
            this.cbCheck.AutoSize = true;
            this.cbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCheck.Location = new System.Drawing.Point(823, 126);
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Size = new System.Drawing.Size(78, 22);
            this.cbCheck.TabIndex = 28;
            this.cbCheck.Text = "Check";
            this.cbCheck.UseVisualStyleBackColor = true;
            // 
            // cbCash
            // 
            this.cbCash.AutoSize = true;
            this.cbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCash.Location = new System.Drawing.Point(823, 165);
            this.cbCash.Name = "cbCash";
            this.cbCash.Size = new System.Drawing.Size(187, 22);
            this.cbCash.TabIndex = 29;
            this.cbCash.Text = "Cash   - 5% discount";
            this.cbCash.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(820, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Choose only 1 method to pay with!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(20, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "10% off if you buy all the adds!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCash);
            this.Controls.Add(this.cbCheck);
            this.Controls.Add(this.cbCreditCard);
            this.Controls.Add(this.btnFinalPrice);
            this.Controls.Add(this.tbFinalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbCarPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.cbParktronik);
            this.Controls.Add(this.cbFog);
            this.Controls.Add(this.cbABS);
            this.Controls.Add(this.pbCars);
            this.Controls.Add(this.rbMercedes);
            this.Controls.Add(this.rbBMW);
            this.Controls.Add(this.rbAudi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAudi;
        private System.Windows.Forms.RadioButton rbBMW;
        private System.Windows.Forms.RadioButton rbMercedes;
        private System.Windows.Forms.PictureBox pbCars;
        private System.Windows.Forms.CheckBox cbABS;
        private System.Windows.Forms.CheckBox cbFog;
        private System.Windows.Forms.CheckBox cbParktronik;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCarPrice;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFinalPrice;
        private System.Windows.Forms.Button btnFinalPrice;
        private System.Windows.Forms.CheckBox cbCreditCard;
        private System.Windows.Forms.CheckBox cbCheck;
        private System.Windows.Forms.CheckBox cbCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

