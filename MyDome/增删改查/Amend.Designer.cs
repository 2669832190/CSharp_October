namespace 增删改查 {
	partial class Amend {
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
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.SexText = new System.Windows.Forms.ComboBox();
			this.PhoneText = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.AddressText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ClassText = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.AgeText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NameText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.IDText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(217, 502);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(252, 73);
			this.button1.TabIndex = 32;
			this.button1.Text = "确定修改";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(244, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(208, 27);
			this.label8.TabIndex = 31;
			this.label8.Text = "请确认所有信息";
			// 
			// SexText
			// 
			this.SexText.Font = new System.Drawing.Font("宋体", 18F);
			this.SexText.FormattingEnabled = true;
			this.SexText.Items.AddRange(new object[] {
            "男",
            "女"});
			this.SexText.Location = new System.Drawing.Point(258, 241);
			this.SexText.Name = "SexText";
			this.SexText.Size = new System.Drawing.Size(84, 32);
			this.SexText.TabIndex = 30;
			// 
			// PhoneText
			// 
			this.PhoneText.Font = new System.Drawing.Font("宋体", 18F);
			this.PhoneText.Location = new System.Drawing.Point(258, 414);
			this.PhoneText.MaxLength = 11;
			this.PhoneText.Name = "PhoneText";
			this.PhoneText.Size = new System.Drawing.Size(254, 35);
			this.PhoneText.TabIndex = 29;
			this.PhoneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 18F);
			this.label5.Location = new System.Drawing.Point(171, 421);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 24);
			this.label5.TabIndex = 28;
			this.label5.Text = "电话：";
			// 
			// AddressText
			// 
			this.AddressText.Font = new System.Drawing.Font("宋体", 18F);
			this.AddressText.Location = new System.Drawing.Point(258, 353);
			this.AddressText.Name = "AddressText";
			this.AddressText.Size = new System.Drawing.Size(254, 35);
			this.AddressText.TabIndex = 27;
			this.AddressText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("宋体", 18F);
			this.label6.Location = new System.Drawing.Point(171, 360);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 24);
			this.label6.TabIndex = 26;
			this.label6.Text = "地址：";
			// 
			// ClassText
			// 
			this.ClassText.Font = new System.Drawing.Font("宋体", 18F);
			this.ClassText.Location = new System.Drawing.Point(258, 294);
			this.ClassText.Name = "ClassText";
			this.ClassText.Size = new System.Drawing.Size(254, 35);
			this.ClassText.TabIndex = 25;
			this.ClassText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("宋体", 18F);
			this.label7.Location = new System.Drawing.Point(171, 301);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 24);
			this.label7.TabIndex = 24;
			this.label7.Text = "班级：";
			// 
			// AgeText
			// 
			this.AgeText.Font = new System.Drawing.Font("宋体", 18F);
			this.AgeText.Location = new System.Drawing.Point(426, 238);
			this.AgeText.MaxLength = 2;
			this.AgeText.Name = "AgeText";
			this.AgeText.Size = new System.Drawing.Size(86, 35);
			this.AgeText.TabIndex = 23;
			this.AgeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 18F);
			this.label4.Location = new System.Drawing.Point(347, 246);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 24);
			this.label4.TabIndex = 22;
			this.label4.Text = "年龄：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 18F);
			this.label3.Location = new System.Drawing.Point(172, 246);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 24);
			this.label3.TabIndex = 21;
			this.label3.Text = "性别：";
			// 
			// NameText
			// 
			this.NameText.Font = new System.Drawing.Font("宋体", 18F);
			this.NameText.Location = new System.Drawing.Point(258, 183);
			this.NameText.Name = "NameText";
			this.NameText.Size = new System.Drawing.Size(254, 35);
			this.NameText.TabIndex = 20;
			this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 18F);
			this.label2.Location = new System.Drawing.Point(171, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 24);
			this.label2.TabIndex = 19;
			this.label2.Text = "姓名：";
			// 
			// IDText
			// 
			this.IDText.Font = new System.Drawing.Font("宋体", 18F);
			this.IDText.Location = new System.Drawing.Point(258, 128);
			this.IDText.MaxLength = 10;
			this.IDText.Name = "IDText";
			this.IDText.Size = new System.Drawing.Size(254, 35);
			this.IDText.TabIndex = 18;
			this.IDText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 18F);
			this.label1.Location = new System.Drawing.Point(171, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 24);
			this.label1.TabIndex = 17;
			this.label1.Text = "学号：";
			// 
			// Amend
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 687);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.SexText);
			this.Controls.Add(this.PhoneText);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.AddressText);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ClassText);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.AgeText);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.NameText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.IDText);
			this.Controls.Add(this.label1);
			this.Name = "Amend";
			this.Text = "Amend";
			this.Load += new System.EventHandler(this.Amend_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox SexText;
		private System.Windows.Forms.TextBox PhoneText;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox AddressText;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox ClassText;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox AgeText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NameText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox IDText;
		private System.Windows.Forms.Label label1;
	}
}