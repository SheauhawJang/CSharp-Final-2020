
namespace CSharp_Final
{
    partial class ConfigForm
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
            this.PlayerIGroup = new System.Windows.Forms.GroupBox();
            this.ClearIAvatarButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.PlayerIAvatarPicture = new System.Windows.Forms.PictureBox();
            this.PlayerIAvatorOpenButton = new System.Windows.Forms.Button();
            this.PlayerIAvatarText = new System.Windows.Forms.TextBox();
            this.PlayerINameText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EnvironmentGroup = new System.Windows.Forms.GroupBox();
            this.LangCombo = new System.Windows.Forms.ComboBox();
            this.TimerLimitUpdown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PlayerIIGroup = new System.Windows.Forms.GroupBox();
            this.ClearIIAvatarButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PlayerIIAvatarPicture = new System.Windows.Forms.PictureBox();
            this.PlayerIIAvatorOpenButton = new System.Windows.Forms.Button();
            this.PlayerIIAvatarText = new System.Windows.Forms.TextBox();
            this.PlayerIINameText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AvatarOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ReplaySpeedUpdown = new System.Windows.Forms.NumericUpDown();
            this.PlayerIGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerIAvatarPicture)).BeginInit();
            this.EnvironmentGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerLimitUpdown)).BeginInit();
            this.PlayerIIGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerIIAvatarPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplaySpeedUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerIGroup
            // 
            this.PlayerIGroup.Controls.Add(this.ClearIAvatarButton);
            this.PlayerIGroup.Controls.Add(this.label9);
            this.PlayerIGroup.Controls.Add(this.PlayerIAvatarPicture);
            this.PlayerIGroup.Controls.Add(this.PlayerIAvatorOpenButton);
            this.PlayerIGroup.Controls.Add(this.PlayerIAvatarText);
            this.PlayerIGroup.Controls.Add(this.PlayerINameText);
            this.PlayerIGroup.Controls.Add(this.label7);
            this.PlayerIGroup.Controls.Add(this.label2);
            this.PlayerIGroup.Controls.Add(this.label1);
            this.PlayerIGroup.Location = new System.Drawing.Point(20, 20);
            this.PlayerIGroup.Name = "PlayerIGroup";
            this.PlayerIGroup.Size = new System.Drawing.Size(200, 400);
            this.PlayerIGroup.TabIndex = 0;
            this.PlayerIGroup.TabStop = false;
            this.PlayerIGroup.Text = "PlayerI";
            // 
            // ClearIAvatarButton
            // 
            this.ClearIAvatarButton.Location = new System.Drawing.Point(114, 362);
            this.ClearIAvatarButton.Name = "ClearIAvatarButton";
            this.ClearIAvatarButton.Size = new System.Drawing.Size(75, 23);
            this.ClearIAvatarButton.TabIndex = 5;
            this.ClearIAvatarButton.Text = "恢复默认";
            this.ClearIAvatarButton.UseVisualStyleBackColor = true;
            this.ClearIAvatarButton.Click += new System.EventHandler(this.ClearAvatarButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.Location = new System.Drawing.Point(12, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "200×240";
            // 
            // PlayerIAvatarPicture
            // 
            this.PlayerIAvatarPicture.BackgroundImage = global::CSharp_Final.Properties.Resources.Head_I;
            this.PlayerIAvatarPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerIAvatarPicture.Location = new System.Drawing.Point(9, 140);
            this.PlayerIAvatarPicture.Name = "PlayerIAvatarPicture";
            this.PlayerIAvatarPicture.Size = new System.Drawing.Size(180, 216);
            this.PlayerIAvatarPicture.TabIndex = 3;
            this.PlayerIAvatarPicture.TabStop = false;
            // 
            // PlayerIAvatorOpenButton
            // 
            this.PlayerIAvatorOpenButton.Location = new System.Drawing.Point(149, 90);
            this.PlayerIAvatorOpenButton.Name = "PlayerIAvatorOpenButton";
            this.PlayerIAvatorOpenButton.Size = new System.Drawing.Size(40, 21);
            this.PlayerIAvatorOpenButton.TabIndex = 2;
            this.PlayerIAvatorOpenButton.Text = "浏览";
            this.PlayerIAvatorOpenButton.UseVisualStyleBackColor = true;
            this.PlayerIAvatorOpenButton.Click += new System.EventHandler(this.PlayerAvatorOpenButton_Click);
            // 
            // PlayerIAvatarText
            // 
            this.PlayerIAvatarText.Location = new System.Drawing.Point(9, 90);
            this.PlayerIAvatarText.Name = "PlayerIAvatarText";
            this.PlayerIAvatarText.Size = new System.Drawing.Size(140, 21);
            this.PlayerIAvatarText.TabIndex = 1;
            this.PlayerIAvatarText.TextChanged += new System.EventHandler(this.PlayerAvatarText_TextChanged);
            // 
            // PlayerINameText
            // 
            this.PlayerINameText.Location = new System.Drawing.Point(9, 40);
            this.PlayerINameText.Name = "PlayerINameText";
            this.PlayerINameText.Size = new System.Drawing.Size(180, 21);
            this.PlayerINameText.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "头像预览";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "头像";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // EnvironmentGroup
            // 
            this.EnvironmentGroup.Controls.Add(this.LangCombo);
            this.EnvironmentGroup.Controls.Add(this.ReplaySpeedUpdown);
            this.EnvironmentGroup.Controls.Add(this.TimerLimitUpdown);
            this.EnvironmentGroup.Controls.Add(this.label6);
            this.EnvironmentGroup.Controls.Add(this.label11);
            this.EnvironmentGroup.Controls.Add(this.label5);
            this.EnvironmentGroup.Location = new System.Drawing.Point(500, 20);
            this.EnvironmentGroup.Name = "EnvironmentGroup";
            this.EnvironmentGroup.Size = new System.Drawing.Size(200, 400);
            this.EnvironmentGroup.TabIndex = 0;
            this.EnvironmentGroup.TabStop = false;
            this.EnvironmentGroup.Text = "Environment";
            // 
            // LangCombo
            // 
            this.LangCombo.FormattingEnabled = true;
            this.LangCombo.Items.AddRange(new object[] {
            "English (United States)",
            "简体中文（中华人民共和国）",
            "繁體中文（中華民國）",
            "日本語（日本国）"});
            this.LangCombo.Location = new System.Drawing.Point(9, 91);
            this.LangCombo.Name = "LangCombo";
            this.LangCombo.Size = new System.Drawing.Size(180, 20);
            this.LangCombo.TabIndex = 2;
            // 
            // TimerLimitUpdown
            // 
            this.TimerLimitUpdown.Location = new System.Drawing.Point(9, 40);
            this.TimerLimitUpdown.Maximum = new decimal(new int[] {
            359999,
            0,
            0,
            0});
            this.TimerLimitUpdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimerLimitUpdown.Name = "TimerLimitUpdown";
            this.TimerLimitUpdown.Size = new System.Drawing.Size(180, 21);
            this.TimerLimitUpdown.TabIndex = 1;
            this.TimerLimitUpdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "语言";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "时间限制(s)";
            // 
            // PlayerIIGroup
            // 
            this.PlayerIIGroup.Controls.Add(this.ClearIIAvatarButton);
            this.PlayerIIGroup.Controls.Add(this.label10);
            this.PlayerIIGroup.Controls.Add(this.PlayerIIAvatarPicture);
            this.PlayerIIGroup.Controls.Add(this.PlayerIIAvatorOpenButton);
            this.PlayerIIGroup.Controls.Add(this.PlayerIIAvatarText);
            this.PlayerIIGroup.Controls.Add(this.PlayerIINameText);
            this.PlayerIIGroup.Controls.Add(this.label8);
            this.PlayerIIGroup.Controls.Add(this.label3);
            this.PlayerIIGroup.Controls.Add(this.label4);
            this.PlayerIIGroup.Location = new System.Drawing.Point(260, 20);
            this.PlayerIIGroup.Name = "PlayerIIGroup";
            this.PlayerIIGroup.Size = new System.Drawing.Size(200, 400);
            this.PlayerIIGroup.TabIndex = 0;
            this.PlayerIIGroup.TabStop = false;
            this.PlayerIIGroup.Text = "PlayerII";
            // 
            // ClearIIAvatarButton
            // 
            this.ClearIIAvatarButton.Location = new System.Drawing.Point(114, 362);
            this.ClearIIAvatarButton.Name = "ClearIIAvatarButton";
            this.ClearIIAvatarButton.Size = new System.Drawing.Size(75, 23);
            this.ClearIIAvatarButton.TabIndex = 5;
            this.ClearIIAvatarButton.Text = "恢复默认";
            this.ClearIIAvatarButton.UseVisualStyleBackColor = true;
            this.ClearIIAvatarButton.Click += new System.EventHandler(this.ClearAvatarButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F);
            this.label10.Location = new System.Drawing.Point(12, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "200×240";
            // 
            // PlayerIIAvatarPicture
            // 
            this.PlayerIIAvatarPicture.BackgroundImage = global::CSharp_Final.Properties.Resources.Head_II;
            this.PlayerIIAvatarPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerIIAvatarPicture.Location = new System.Drawing.Point(9, 140);
            this.PlayerIIAvatarPicture.Name = "PlayerIIAvatarPicture";
            this.PlayerIIAvatarPicture.Size = new System.Drawing.Size(180, 216);
            this.PlayerIIAvatarPicture.TabIndex = 3;
            this.PlayerIIAvatarPicture.TabStop = false;
            // 
            // PlayerIIAvatorOpenButton
            // 
            this.PlayerIIAvatorOpenButton.Location = new System.Drawing.Point(149, 90);
            this.PlayerIIAvatorOpenButton.Name = "PlayerIIAvatorOpenButton";
            this.PlayerIIAvatorOpenButton.Size = new System.Drawing.Size(40, 21);
            this.PlayerIIAvatorOpenButton.TabIndex = 2;
            this.PlayerIIAvatorOpenButton.Text = "浏览";
            this.PlayerIIAvatorOpenButton.UseVisualStyleBackColor = true;
            this.PlayerIIAvatorOpenButton.Click += new System.EventHandler(this.PlayerAvatorOpenButton_Click);
            // 
            // PlayerIIAvatarText
            // 
            this.PlayerIIAvatarText.Location = new System.Drawing.Point(9, 90);
            this.PlayerIIAvatarText.Name = "PlayerIIAvatarText";
            this.PlayerIIAvatarText.Size = new System.Drawing.Size(140, 21);
            this.PlayerIIAvatarText.TabIndex = 1;
            this.PlayerIIAvatarText.TextChanged += new System.EventHandler(this.PlayerAvatarText_TextChanged);
            // 
            // PlayerIINameText
            // 
            this.PlayerIINameText.Location = new System.Drawing.Point(9, 40);
            this.PlayerIINameText.Name = "PlayerIINameText";
            this.PlayerIINameText.Size = new System.Drawing.Size(180, 21);
            this.PlayerIINameText.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "头像预览";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "头像";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(500, 426);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 25);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "重置";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearConfigButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(260, 426);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(200, 25);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "提交";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AvatarOpenDialog
            // 
            this.AvatarOpenDialog.FileName = "AvatarOpenDialog";
            this.AvatarOpenDialog.Filter = "JPEG文件|*.jpg;*.jpeg|GIF文件|*.gif|BMP文件|*.bmp|PNG文件|*.png|所有文件|*.*";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(625, 426);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "回放延迟(ms)";
            // 
            // ReplaySpeedUpdown
            // 
            this.ReplaySpeedUpdown.Location = new System.Drawing.Point(9, 140);
            this.ReplaySpeedUpdown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ReplaySpeedUpdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ReplaySpeedUpdown.Name = "ReplaySpeedUpdown";
            this.ReplaySpeedUpdown.Size = new System.Drawing.Size(180, 21);
            this.ReplaySpeedUpdown.TabIndex = 1;
            this.ReplaySpeedUpdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 471);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EnvironmentGroup);
            this.Controls.Add(this.PlayerIIGroup);
            this.Controls.Add(this.PlayerIGroup);
            this.Name = "ConfigForm";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.ClearConfigButton_Click);
            this.PlayerIGroup.ResumeLayout(false);
            this.PlayerIGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerIAvatarPicture)).EndInit();
            this.EnvironmentGroup.ResumeLayout(false);
            this.EnvironmentGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerLimitUpdown)).EndInit();
            this.PlayerIIGroup.ResumeLayout(false);
            this.PlayerIIGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerIIAvatarPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplaySpeedUpdown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PlayerIGroup;
        private System.Windows.Forms.PictureBox PlayerIAvatarPicture;
        private System.Windows.Forms.Button PlayerIAvatorOpenButton;
        private System.Windows.Forms.TextBox PlayerIAvatarText;
        private System.Windows.Forms.TextBox PlayerINameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox EnvironmentGroup;
        private System.Windows.Forms.ComboBox LangCombo;
        private System.Windows.Forms.NumericUpDown TimerLimitUpdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox PlayerIIGroup;
        private System.Windows.Forms.Button PlayerIIAvatorOpenButton;
        private System.Windows.Forms.TextBox PlayerIIAvatarText;
        private System.Windows.Forms.TextBox PlayerIINameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox PlayerIIAvatarPicture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.OpenFileDialog AvatarOpenDialog;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ClearIAvatarButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ClearIIAvatarButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ReplaySpeedUpdown;
        private System.Windows.Forms.Label label11;
    }
}