namespace tctclient
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
            this.adres = new System.Windows.Forms.TextBox();
            this.my_port = new System.Windows.Forms.TextBox();
            this.info_o_polaczeniu = new System.Windows.Forms.TextBox();
            this.przycisk_polacz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(12, 12);
            this.adres.MaxLength = 65535;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(335, 20);
            this.adres.TabIndex = 0;
            this.adres.Text = "adres";
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(398, 12);
            this.my_port.MaxLength = 65535;
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(421, 20);
            this.my_port.TabIndex = 1;
            this.my_port.Text = "0";
            this.my_port.TextChanged += new System.EventHandler(this.numericUPdown_TextChanged);
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.Location = new System.Drawing.Point(78, 38);
            this.info_o_polaczeniu.MaxLength = 65535;
            this.info_o_polaczeniu.Multiline = true;
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(664, 248);
            this.info_o_polaczeniu.TabIndex = 2;
            this.info_o_polaczeniu.Text = "info o polaczeniu";
            // 
            // przycisk_polacz
            // 
            this.przycisk_polacz.Location = new System.Drawing.Point(238, 283);
            this.przycisk_polacz.Name = "przycisk_polacz";
            this.przycisk_polacz.Size = new System.Drawing.Size(270, 113);
            this.przycisk_polacz.TabIndex = 3;
            this.przycisk_polacz.Text = "polacz";
            this.przycisk_polacz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 398);
            this.Controls.Add(this.przycisk_polacz);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox my_port;
        private System.Windows.Forms.TextBox info_o_polaczeniu;
        private System.Windows.Forms.Button przycisk_polacz;
    }
}

