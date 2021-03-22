
namespace bluetoothTest2
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
            this.listBoxDeviceList = new System.Windows.Forms.ListBox();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDeviceList
            // 
            this.listBoxDeviceList.FormattingEnabled = true;
            this.listBoxDeviceList.ItemHeight = 15;
            this.listBoxDeviceList.Location = new System.Drawing.Point(16, 15);
            this.listBoxDeviceList.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDeviceList.Name = "listBoxDeviceList";
            this.listBoxDeviceList.Size = new System.Drawing.Size(933, 289);
            this.listBoxDeviceList.TabIndex = 0;
            // 
            // btnDiscover
            // 
            this.btnDiscover.Location = new System.Drawing.Point(16, 351);
            this.btnDiscover.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(212, 58);
            this.btnDiscover.TabIndex = 1;
            this.btnDiscover.Text = "搜尋藍芽裝置";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(263, 351);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(212, 58);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "連線藍芽裝置";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDiscover);
            this.Controls.Add(this.listBoxDeviceList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDeviceList;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Button btnConnect;
    }
}

