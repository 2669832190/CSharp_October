namespace 窗体传值修改 {
	partial class Update {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.UserNameText = new System.Windows.Forms.TextBox();
			this.UserPassWordText = new System.Windows.Forms.TextBox();
			this.Username = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UserNameText
			// 
			this.UserNameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.UserNameText.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.UserNameText.Location = new System.Drawing.Point(304, 99);
			this.UserNameText.Name = "UserNameText";
			this.UserNameText.ReadOnly = true;
			this.UserNameText.Size = new System.Drawing.Size(282, 35);
			this.UserNameText.TabIndex = 0;
			// 
			// UserPassWordText
			// 
			this.UserPassWordText.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.UserPassWordText.Location = new System.Drawing.Point(304, 191);
			this.UserPassWordText.Name = "UserPassWordText";
			this.UserPassWordText.Size = new System.Drawing.Size(282, 35);
			this.UserPassWordText.TabIndex = 1;
			// 
			// Username
			// 
			this.Username.AutoSize = true;
			this.Username.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Username.Location = new System.Drawing.Point(123, 103);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(178, 24);
			this.Username.TabIndex = 2;
			this.Username.Text = "UserNameText：";
			// 
			// Password
			// 
			this.Password.AutoSize = true;
			this.Password.BackColor = System.Drawing.SystemColors.Control;
			this.Password.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Password.Location = new System.Drawing.Point(123, 194);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(178, 24);
			this.Password.TabIndex = 3;
			this.Password.Text = "PasswordText：";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(283, 301);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(207, 69);
			this.button1.TabIndex = 4;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.UserPassWordText);
			this.Controls.Add(this.UserNameText);
			this.Name = "Update";
			this.Text = "Update";
			this.Load += new System.EventHandler(this.Update_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox UserNameText;
		private System.Windows.Forms.TextBox UserPassWordText;
		private System.Windows.Forms.Label Username;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.Button button1;
	}
}