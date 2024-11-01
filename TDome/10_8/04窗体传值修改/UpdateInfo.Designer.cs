namespace _04窗体传值修改
{
    partial class UpdateInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInfo = new System.Windows.Forms.TextBox();
            this.pwdInfo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(128, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(128, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码:";
            // 
            // nameInfo
            // 
            this.nameInfo.Font = new System.Drawing.Font("宋体", 20F);
            this.nameInfo.Location = new System.Drawing.Point(214, 92);
            this.nameInfo.Name = "nameInfo";
            this.nameInfo.ReadOnly = true;
            this.nameInfo.Size = new System.Drawing.Size(209, 38);
            this.nameInfo.TabIndex = 2;
            // 
            // pwdInfo
            // 
            this.pwdInfo.Font = new System.Drawing.Font("宋体", 20F);
            this.pwdInfo.Location = new System.Drawing.Point(214, 181);
            this.pwdInfo.Name = "pwdInfo";
            this.pwdInfo.Size = new System.Drawing.Size(209, 38);
            this.pwdInfo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwdInfo);
            this.Controls.Add(this.nameInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateInfo";
            this.Text = "UpdateInfo";
            this.Load += new System.EventHandler(this.UpdateInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameInfo;
        private System.Windows.Forms.TextBox pwdInfo;
        private System.Windows.Forms.Button button1;
    }
}