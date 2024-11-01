namespace 产品检测.Forms {
	partial class FormSpSet1 {
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
			this.SpName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.Btl = new System.Windows.Forms.ComboBox();
			this.Sjw = new System.Windows.Forms.ComboBox();
			this.Jyw = new System.Windows.Forms.ComboBox();
			this.Tzw = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(116, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "名称：";
			// 
			// SpName
			// 
			this.SpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SpName.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.SpName.Location = new System.Drawing.Point(203, 110);
			this.SpName.Name = "SpName";
			this.SpName.Size = new System.Drawing.Size(190, 35);
			this.SpName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(92, 348);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "停止位：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(92, 285);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "校验位：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(92, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "数据位：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(91, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 24);
			this.label5.TabIndex = 8;
			this.label5.Text = "波特率：";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(95, 428);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 54);
			this.button1.TabIndex = 6;
			this.button1.Text = "保存";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(286, 428);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 54);
			this.button2.TabIndex = 7;
			this.button2.Text = "取消";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Btl
			// 
			this.Btl.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Btl.FormattingEnabled = true;
			this.Btl.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
			this.Btl.Location = new System.Drawing.Point(203, 175);
			this.Btl.Name = "Btl";
			this.Btl.Size = new System.Drawing.Size(191, 32);
			this.Btl.TabIndex = 2;
			// 
			// Sjw
			// 
			this.Sjw.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Sjw.FormattingEnabled = true;
			this.Sjw.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
			this.Sjw.Location = new System.Drawing.Point(202, 227);
			this.Sjw.Name = "Sjw";
			this.Sjw.Size = new System.Drawing.Size(191, 32);
			this.Sjw.TabIndex = 3;
			// 
			// Jyw
			// 
			this.Jyw.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Jyw.FormattingEnabled = true;
			this.Jyw.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
			this.Jyw.Location = new System.Drawing.Point(203, 285);
			this.Jyw.Name = "Jyw";
			this.Jyw.Size = new System.Drawing.Size(191, 32);
			this.Jyw.TabIndex = 4;
			// 
			// Tzw
			// 
			this.Tzw.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Tzw.FormattingEnabled = true;
			this.Tzw.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
			this.Tzw.Location = new System.Drawing.Point(203, 340);
			this.Tzw.Name = "Tzw";
			this.Tzw.Size = new System.Drawing.Size(191, 32);
			this.Tzw.TabIndex = 5;
			// 
			// FormSpSet1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 587);
			this.Controls.Add(this.Tzw);
			this.Controls.Add(this.Jyw);
			this.Controls.Add(this.Sjw);
			this.Controls.Add(this.Btl);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SpName);
			this.Controls.Add(this.label1);
			this.Name = "FormSpSet1";
			this.Text = "FormSpSet";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSpSet1_FormClosed);
			this.Load += new System.EventHandler(this.FormSpSet_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SpName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox Btl;
		private System.Windows.Forms.ComboBox Sjw;
		private System.Windows.Forms.ComboBox Jyw;
		private System.Windows.Forms.ComboBox Tzw;
	}
}