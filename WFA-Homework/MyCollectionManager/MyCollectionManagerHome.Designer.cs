namespace MyCollectionManager
{
    partial class MyCollectionManagerHome
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
            this.tbCatName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbCats = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCatName
            // 
            this.tbCatName.Location = new System.Drawing.Point(12, 57);
            this.tbCatName.Name = "tbCatName";
            this.tbCatName.Size = new System.Drawing.Size(237, 22);
            this.tbCatName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 67);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(145, 85);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(104, 67);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show me!";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbCats
            // 
            this.lbCats.FormattingEnabled = true;
            this.lbCats.ItemHeight = 16;
            this.lbCats.Location = new System.Drawing.Point(266, 28);
            this.lbCats.Name = "lbCats";
            this.lbCats.Size = new System.Drawing.Size(388, 404);
            this.lbCats.TabIndex = 3;
            this.lbCats.SelectedIndexChanged += new System.EventHandler(this.lbCats_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(145, 365);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 67);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 365);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 67);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "50",
            "100"});
            this.comboBox1.Location = new System.Drawing.Point(672, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(672, 85);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(104, 67);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(12, 191);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(104, 43);
            this.btnTop.TabIndex = 8;
            this.btnTop.Text = "Move to the Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(145, 191);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(104, 43);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "One Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(145, 270);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(104, 43);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "One Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Location = new System.Drawing.Point(12, 270);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(104, 43);
            this.btnBottom.TabIndex = 11;
            this.btnBottom.Text = "Move to the Bottom";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // MyCollectionManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbCats);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCatName);
            this.Name = "MyCollectionManagerHome";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCatName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lbCats;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnBottom;
    }
}

