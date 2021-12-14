namespace Assignment5
{
    partial class InformationOfUserGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationOfUserGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameInfo = new System.Windows.Forms.TextBox();
            this.txtEmailInfo = new System.Windows.Forms.TextBox();
            this.txtGenderInfo = new System.Windows.Forms.TextBox();
            this.txtPhoneInfo = new System.Windows.Forms.TextBox();
            this.txtAddressInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address :";
            // 
            // txtNameInfo
            // 
            this.txtNameInfo.Location = new System.Drawing.Point(102, 29);
            this.txtNameInfo.Name = "txtNameInfo";
            this.txtNameInfo.Size = new System.Drawing.Size(100, 20);
            this.txtNameInfo.TabIndex = 5;
            this.txtNameInfo.TextChanged += new System.EventHandler(this.txtNameInfo_TextChanged);
            // 
            // txtEmailInfo
            // 
            this.txtEmailInfo.Location = new System.Drawing.Point(102, 71);
            this.txtEmailInfo.Name = "txtEmailInfo";
            this.txtEmailInfo.Size = new System.Drawing.Size(100, 20);
            this.txtEmailInfo.TabIndex = 6;
            // 
            // txtGenderInfo
            // 
            this.txtGenderInfo.Location = new System.Drawing.Point(102, 115);
            this.txtGenderInfo.Name = "txtGenderInfo";
            this.txtGenderInfo.Size = new System.Drawing.Size(100, 20);
            this.txtGenderInfo.TabIndex = 7;
            // 
            // txtPhoneInfo
            // 
            this.txtPhoneInfo.Location = new System.Drawing.Point(102, 161);
            this.txtPhoneInfo.Name = "txtPhoneInfo";
            this.txtPhoneInfo.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneInfo.TabIndex = 8;
            // 
            // txtAddressInfo
            // 
            this.txtAddressInfo.Location = new System.Drawing.Point(102, 206);
            this.txtAddressInfo.Name = "txtAddressInfo";
            this.txtAddressInfo.Size = new System.Drawing.Size(100, 20);
            this.txtAddressInfo.TabIndex = 9;
            // 
            // InformationOfUserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 247);
            this.Controls.Add(this.txtAddressInfo);
            this.Controls.Add(this.txtPhoneInfo);
            this.Controls.Add(this.txtGenderInfo);
            this.Controls.Add(this.txtEmailInfo);
            this.Controls.Add(this.txtNameInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformationOfUserGUI";
            this.Text = "Information of User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameInfo;
        private System.Windows.Forms.TextBox txtEmailInfo;
        private System.Windows.Forms.TextBox txtGenderInfo;
        private System.Windows.Forms.TextBox txtPhoneInfo;
        private System.Windows.Forms.TextBox txtAddressInfo;
    }
}