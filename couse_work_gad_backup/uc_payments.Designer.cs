namespace couse_work_gad
{
    partial class uc_payments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_yy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_pay = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_MM = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cardholdername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_cardnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmb_yy);
            this.panel1.Controls.Add(this.btn_pay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_MM);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_cardholdername);
            this.panel1.Controls.Add(this.txt_cardnumber);
            this.panel1.Location = new System.Drawing.Point(115, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 433);
            this.panel1.TabIndex = 1;
            // 
            // cmb_yy
            // 
            this.cmb_yy.BackColor = System.Drawing.Color.Transparent;
            this.cmb_yy.BorderRadius = 8;
            this.cmb_yy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_yy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_yy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_yy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_yy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_yy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_yy.ItemHeight = 30;
            this.cmb_yy.Items.AddRange(new object[] {
            " 2023",
            "2024",
            "2035",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034"});
            this.cmb_yy.Location = new System.Drawing.Point(239, 196);
            this.cmb_yy.Name = "cmb_yy";
            this.cmb_yy.Size = new System.Drawing.Size(140, 36);
            this.cmb_yy.TabIndex = 12;
            // 
            // btn_pay
            // 
            this.btn_pay.BorderRadius = 8;
            this.btn_pay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_pay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_pay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_pay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(107)))), ((int)(((byte)(147)))));
            this.btn_pay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.Location = new System.Drawing.Point(53, 303);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(261, 54);
            this.btn_pay.TabIndex = 11;
            this.btn_pay.Text = " Pay 100$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(235, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "YY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "MM";
            // 
            // cmb_MM
            // 
            this.cmb_MM.BackColor = System.Drawing.Color.Transparent;
            this.cmb_MM.BorderRadius = 8;
            this.cmb_MM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_MM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MM.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_MM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_MM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_MM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_MM.ItemHeight = 30;
            this.cmb_MM.Items.AddRange(new object[] {
            "january(01)",
            "February(02)",
            "March(03)",
            "April(04)",
            "May(05)",
            "June(06)",
            "July(07)",
            "August(08)",
            "September(09)",
            "October(010)",
            "November(11)",
            "December(12)"});
            this.cmb_MM.Location = new System.Drawing.Point(53, 196);
            this.cmb_MM.Name = "cmb_MM";
            this.cmb_MM.Size = new System.Drawing.Size(134, 36);
            this.cmb_MM.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(624, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cardholder Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Card Number";
            // 
            // txt_cardholdername
            // 
            this.txt_cardholdername.BorderRadius = 9;
            this.txt_cardholdername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cardholdername.DefaultText = "";
            this.txt_cardholdername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cardholdername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cardholdername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cardholdername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cardholdername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cardholdername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cardholdername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cardholdername.Location = new System.Drawing.Point(628, 67);
            this.txt_cardholdername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_cardholdername.Name = "txt_cardholdername";
            this.txt_cardholdername.PasswordChar = '\0';
            this.txt_cardholdername.PlaceholderText = "";
            this.txt_cardholdername.SelectedText = "";
            this.txt_cardholdername.Size = new System.Drawing.Size(431, 53);
            this.txt_cardholdername.TabIndex = 1;
            // 
            // txt_cardnumber
            // 
            this.txt_cardnumber.BorderRadius = 9;
            this.txt_cardnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cardnumber.DefaultText = "";
            this.txt_cardnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cardnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cardnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cardnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cardnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cardnumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cardnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cardnumber.Location = new System.Drawing.Point(53, 67);
            this.txt_cardnumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_cardnumber.Name = "txt_cardnumber";
            this.txt_cardnumber.PasswordChar = '\0';
            this.txt_cardnumber.PlaceholderText = "";
            this.txt_cardnumber.SelectedText = "";
            this.txt_cardnumber.Size = new System.Drawing.Size(464, 53);
            this.txt_cardnumber.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::couse_work_gad.Properties.Resources.visa;
            this.pictureBox1.Location = new System.Drawing.Point(628, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // uc_payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_payments";
            this.Size = new System.Drawing.Size(1341, 581);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_yy;
        private Guna.UI2.WinForms.Guna2Button btn_pay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_MM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_cardholdername;
        private Guna.UI2.WinForms.Guna2TextBox txt_cardnumber;
    }
}
