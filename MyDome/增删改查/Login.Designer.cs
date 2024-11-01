namespace 增删改查 {
	partial class Login {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.UserNameText = new System.Windows.Forms.TextBox();
			this.User = new System.Windows.Forms.Label();
			this.Pasw = new System.Windows.Forms.Label();
			this.UserPassWordText = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UserNameText
			// 
			this.UserNameText.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.UserNameText.Location = new System.Drawing.Point(297, 98);
			this.UserNameText.Name = "UserNameText";
			this.UserNameText.Size = new System.Drawing.Size(247, 41);
			this.UserNameText.TabIndex = 0;
			// 
			// User
			// 
			this.User.AutoSize = true;
			this.User.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.User.Location = new System.Drawing.Point(190, 108);
			this.User.Name = "User";
			this.User.Size = new System.Drawing.Size(102, 29);
			this.User.TabIndex = 1;
			this.User.Text = "User：";
			// 
			// Pasw
			// 
			this.Pasw.AutoSize = true;
			this.Pasw.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Pasw.Location = new System.Drawing.Point(190, 188);
			this.Pasw.Name = "Pasw";
			this.Pasw.Size = new System.Drawing.Size(102, 29);
			this.Pasw.TabIndex = 3;
			this.Pasw.Text = "Pasw：";
			// 
			// UserPassWordText
			// 
			this.UserPassWordText.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.UserPassWordText.Location = new System.Drawing.Point(297, 178);
			this.UserPassWordText.Name = "UserPassWordText";
			this.UserPassWordText.PasswordChar = '*';
			this.UserPassWordText.Size = new System.Drawing.Size(247, 41);
			this.UserPassWordText.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(297, 269);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 62);
			this.button1.TabIndex = 4;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Pasw);
			this.Controls.Add(this.UserPassWordText);
			this.Controls.Add(this.User);
			this.Controls.Add(this.UserNameText);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox UserNameText;
		private System.Windows.Forms.Label User;
		private System.Windows.Forms.Label Pasw;
		private System.Windows.Forms.TextBox UserPassWordText;
		private System.Windows.Forms.Button button1;
	}
}

