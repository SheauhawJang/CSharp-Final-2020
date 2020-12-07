namespace CSharp_Final
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.OpenRecordDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BoardPanel
            // 
            this.BoardPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.BoardPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoardPanel.Location = new System.Drawing.Point(50, 50);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(750, 750);
            this.BoardPanel.TabIndex = 0;
            this.BoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BoradPanel_Paint);
            this.BoardPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BoardPanel_MouseUp);
            // 
            // OpenRecordDialog
            // 
            this.OpenRecordDialog.FileName = "openFileDialog1";
            this.OpenRecordDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenRecordDialog_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 841);
            this.Controls.Add(this.BoardPanel);
            this.Name = "MainForm";
            this.Text = "五子棋对战程序";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.OpenFileDialog OpenRecordDialog;
    }
}

