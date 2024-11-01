namespace 增删改查 {
	partial class Inquire {
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
			this.label1 = new System.Windows.Forms.Label();
			this.TypeText = new System.Windows.Forms.ComboBox();
			this.ItemText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 18F);
			this.label1.Location = new System.Drawing.Point(244, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "查询类别：";
			// 
			// TypeText
			// 
			this.TypeText.Font = new System.Drawing.Font("宋体", 18F);
			this.TypeText.FormattingEnabled = true;
			this.TypeText.Items.AddRange(new object[] {
            "学号",
            "姓名",
            "性别",
            "年龄",
            "班级",
            "地址",
            "电话",
            "模糊查询"});
			this.TypeText.Location = new System.Drawing.Point(380, 75);
			this.TypeText.Name = "TypeText";
			this.TypeText.Size = new System.Drawing.Size(161, 32);
			this.TypeText.TabIndex = 1;
			// 
			// ItemText
			// 
			this.ItemText.Font = new System.Drawing.Font("宋体", 18F);
			this.ItemText.Location = new System.Drawing.Point(693, 75);
			this.ItemText.Name = "ItemText";
			this.ItemText.Size = new System.Drawing.Size(296, 35);
			this.ItemText.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 18F);
			this.label2.Location = new System.Drawing.Point(581, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "查询项：";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 18F);
			this.button1.Location = new System.Drawing.Point(1045, 78);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 37);
			this.button1.TabIndex = 4;
			this.button1.Text = "查询";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Inquire
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1508, 620);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ItemText);
			this.Controls.Add(this.TypeText);
			this.Controls.Add(this.label1);
			this.Name = "Inquire";
			this.Text = "Inquire";
			this.Load += new System.EventHandler(this.Inquire_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox TypeText;
		private System.Windows.Forms.TextBox ItemText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}