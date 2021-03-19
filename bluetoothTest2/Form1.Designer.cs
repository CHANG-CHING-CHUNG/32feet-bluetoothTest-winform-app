
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
            this.SuspendLayout();
            // 
            // listBoxDeviceList
            // 
            this.listBoxDeviceList.FormattingEnabled = true;
            this.listBoxDeviceList.ItemHeight = 12;
            this.listBoxDeviceList.Location = new System.Drawing.Point(12, 12);
            this.listBoxDeviceList.Name = "listBoxDeviceList";
            this.listBoxDeviceList.Size = new System.Drawing.Size(701, 232);
            this.listBoxDeviceList.TabIndex = 0;
            // 
            // btnDiscover
            // 
            this.btnDiscover.Location = new System.Drawing.Point(12, 281);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(159, 46);
            this.btnDiscover.TabIndex = 1;
            this.btnDiscover.Text = "搜尋藍芽裝置";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiscover);
            this.Controls.Add(this.listBoxDeviceList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDeviceList;
        private System.Windows.Forms.Button btnDiscover;
    }
}

