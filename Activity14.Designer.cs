namespace Activity14
{
    partial class ShapeMaker
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
            this.listBox_Shape = new System.Windows.Forms.ListBox();
            this.radioBtn_white = new System.Windows.Forms.RadioButton();
            this.radioBtn_black = new System.Windows.Forms.RadioButton();
            this.checkBox_name = new System.Windows.Forms.CheckBox();
            this.checkBox_date = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_display = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Shape
            // 
            this.listBox_Shape.BackColor = System.Drawing.SystemColors.Window;
            this.listBox_Shape.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Shape.FormattingEnabled = true;
            this.listBox_Shape.ItemHeight = 19;
            this.listBox_Shape.Items.AddRange(new object[] {
            "Square",
            "Circle",
            "Triangle"});
            this.listBox_Shape.Location = new System.Drawing.Point(62, 112);
            this.listBox_Shape.Name = "listBox_Shape";
            this.listBox_Shape.Size = new System.Drawing.Size(181, 61);
            this.listBox_Shape.TabIndex = 0;
            this.listBox_Shape.SelectedIndexChanged += new System.EventHandler(this.listBox_Shape_SelectedIndexChanged);
            // 
            // radioBtn_white
            // 
            this.radioBtn_white.AutoSize = true;
            this.radioBtn_white.Location = new System.Drawing.Point(17, 20);
            this.radioBtn_white.Name = "radioBtn_white";
            this.radioBtn_white.Size = new System.Drawing.Size(54, 19);
            this.radioBtn_white.TabIndex = 1;
            this.radioBtn_white.TabStop = true;
            this.radioBtn_white.Text = "white";
            this.radioBtn_white.UseVisualStyleBackColor = true;
            // 
            // radioBtn_black
            // 
            this.radioBtn_black.AutoSize = true;
            this.radioBtn_black.Location = new System.Drawing.Point(17, 44);
            this.radioBtn_black.Name = "radioBtn_black";
            this.radioBtn_black.Size = new System.Drawing.Size(54, 19);
            this.radioBtn_black.TabIndex = 2;
            this.radioBtn_black.TabStop = true;
            this.radioBtn_black.Text = "black";
            this.radioBtn_black.UseVisualStyleBackColor = true;
            // 
            // checkBox_name
            // 
            this.checkBox_name.AutoSize = true;
            this.checkBox_name.Location = new System.Drawing.Point(17, 25);
            this.checkBox_name.Name = "checkBox_name";
            this.checkBox_name.Size = new System.Drawing.Size(58, 19);
            this.checkBox_name.TabIndex = 3;
            this.checkBox_name.Text = "name";
            this.checkBox_name.UseVisualStyleBackColor = true;
            // 
            // checkBox_date
            // 
            this.checkBox_date.AutoSize = true;
            this.checkBox_date.Location = new System.Drawing.Point(17, 50);
            this.checkBox_date.Name = "checkBox_date";
            this.checkBox_date.Size = new System.Drawing.Size(50, 19);
            this.checkBox_date.TabIndex = 4;
            this.checkBox_date.Text = "date";
            this.checkBox_date.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(336, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(443, 337);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(406, 362);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 13);
            this.lbl_date.TabIndex = 9;
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_display
            // 
            this.btn_display.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_display.FlatAppearance.BorderSize = 0;
            this.btn_display.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.ForeColor = System.Drawing.Color.White;
            this.btn_display.Location = new System.Drawing.Point(62, 437);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(181, 44);
            this.btn_display.TabIndex = 10;
            this.btn_display.Text = "DISPLAY";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioBtn_black);
            this.panel2.Controls.Add(this.radioBtn_white);
            this.panel2.Font = new System.Drawing.Font("Arial", 9F);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(62, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 88);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select color ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(66, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select details";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBox_name);
            this.panel3.Controls.Add(this.checkBox_date);
            this.panel3.Font = new System.Drawing.Font("Arial", 9F);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(62, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 88);
            this.panel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(60, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select Shape";
            // 
            // ShapeMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(687, 599);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox_Shape);
            this.Controls.Add(this.panel2);
            this.Name = "ShapeMaker";
            this.Text = "Shape Maker";
            this.Load += new System.EventHandler(this.ShapeMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Shape;
        private System.Windows.Forms.RadioButton radioBtn_white;
        private System.Windows.Forms.RadioButton radioBtn_black;
        private System.Windows.Forms.CheckBox checkBox_name;
        private System.Windows.Forms.CheckBox checkBox_date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}

