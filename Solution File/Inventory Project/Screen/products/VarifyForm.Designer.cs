namespace Inventory_Project.Screen.products
{
    partial class VarifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VarifyForm));
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsend = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvarifycode = new System.Windows.Forms.TextBox();
            this.btnverify = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtemail.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(206, 208);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(371, 43);
            this.txtemail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter any Valid Email";
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsend.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnsend.Location = new System.Drawing.Point(299, 252);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(184, 55);
            this.btnsend.TabIndex = 4;
            this.btnsend.Text = "SEND";
            this.btnsend.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnsend.UseSelectable = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1225, 635);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varify Code";
            // 
            // txtvarifycode
            // 
            this.txtvarifycode.BackColor = System.Drawing.SystemColors.Menu;
            this.txtvarifycode.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvarifycode.Location = new System.Drawing.Point(264, 367);
            this.txtvarifycode.Name = "txtvarifycode";
            this.txtvarifycode.Size = new System.Drawing.Size(254, 43);
            this.txtvarifycode.TabIndex = 1;
            // 
            // btnverify
            // 
            this.btnverify.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnverify.Location = new System.Drawing.Point(324, 411);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(134, 55);
            this.btnverify.TabIndex = 5;
            this.btnverify.Text = "Varify";
            this.btnverify.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnverify.UseSelectable = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // VarifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 715);
            this.Controls.Add(this.btnverify);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvarifycode);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VarifyForm";
            this.Text = "VarifyForm";
            this.Load += new System.EventHandler(this.VarifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnsend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvarifycode;
        private MetroFramework.Controls.MetroButton btnverify;
    }
}