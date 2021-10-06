
namespace printerWindowsApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.printerList = new System.Windows.Forms.ListBox();
            this.getPrinterInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IP_ADDRESS_LIST = new System.Windows.Forms.RichTextBox();
            this.IP_ADDRESS_LABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printerList
            // 
            this.printerList.FormattingEnabled = true;
            this.printerList.HorizontalScrollbar = true;
            this.printerList.ItemHeight = 18;
            this.printerList.Location = new System.Drawing.Point(229, 62);
            this.printerList.Name = "printerList";
            this.printerList.ScrollAlwaysVisible = true;
            this.printerList.Size = new System.Drawing.Size(559, 184);
            this.printerList.TabIndex = 0;
            // 
            // getPrinterInfo
            // 
            this.getPrinterInfo.Location = new System.Drawing.Point(591, 12);
            this.getPrinterInfo.Name = "getPrinterInfo";
            this.getPrinterInfo.Size = new System.Drawing.Size(197, 37);
            this.getPrinterInfo.TabIndex = 1;
            this.getPrinterInfo.Text = "現在のプリンターを取得";
            this.getPrinterInfo.UseVisualStyleBackColor = true;
            this.getPrinterInfo.Click += new System.EventHandler(this.getPrinterInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ネットワークプリンター";
            // 
            // IP_ADDRESS_LIST
            // 
            this.IP_ADDRESS_LIST.Location = new System.Drawing.Point(12, 62);
            this.IP_ADDRESS_LIST.Name = "IP_ADDRESS_LIST";
            this.IP_ADDRESS_LIST.Size = new System.Drawing.Size(209, 184);
            this.IP_ADDRESS_LIST.TabIndex = 3;
            this.IP_ADDRESS_LIST.Text = "";
            // 
            // IP_ADDRESS_LABEL
            // 
            this.IP_ADDRESS_LABEL.AutoSize = true;
            this.IP_ADDRESS_LABEL.Location = new System.Drawing.Point(12, 31);
            this.IP_ADDRESS_LABEL.Name = "IP_ADDRESS_LABEL";
            this.IP_ADDRESS_LABEL.Size = new System.Drawing.Size(78, 18);
            this.IP_ADDRESS_LABEL.TabIndex = 4;
            this.IP_ADDRESS_LABEL.Text = "IPアドレス";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IP_ADDRESS_LABEL);
            this.Controls.Add(this.IP_ADDRESS_LIST);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getPrinterInfo);
            this.Controls.Add(this.printerList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox printerList;
        private System.Windows.Forms.Button getPrinterInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox IP_ADDRESS_LIST;
        private System.Windows.Forms.Label IP_ADDRESS_LABEL;
    }
}

