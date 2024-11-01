namespace 增删改查 {
	partial class StudentMessages {
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
			this.StudentID = new System.Windows.Forms.Label();
			this.StudentName = new System.Windows.Forms.Label();
			this.StudentSex = new System.Windows.Forms.Label();
			this.StudentAge = new System.Windows.Forms.Label();
			this.StudentClass = new System.Windows.Forms.Label();
			this.StudentAddress = new System.Windows.Forms.Label();
			this.StudentPhone = new System.Windows.Forms.Label();
			this.AddStudentMessages = new System.Windows.Forms.Button();
			this.InquireMessages = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StudentID
			// 
			this.StudentID.AutoSize = true;
			this.StudentID.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.StudentID.Location = new System.Drawing.Point(28, 67);
			this.StudentID.Name = "StudentID";
			this.StudentID.Size = new System.Drawing.Size(60, 24);
			this.StudentID.TabIndex = 0;
			this.StudentID.Text = "学号";
			// 
			// StudentName
			// 
			this.StudentName.AutoSize = true;
			this.StudentName.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.StudentName.Location = new System.Drawing.Point(180, 67);
			this.StudentName.Name = "StudentName";
			this.StudentName.Size = new System.Drawing.Size(60, 24);
			this.StudentName.TabIndex = 1;
			this.StudentName.Text = "姓名";
			// 
			// StudentSex
			// 
			this.StudentSex.AutoSize = true;
			this.StudentSex.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.StudentSex.Location = new System.Drawing.Point(311, 67);
			this.StudentSex.Name = "StudentSex";
			this.StudentSex.Size = new System.Drawing.Size(60, 24);
			this.StudentSex.TabIndex = 2;
			this.StudentSex.Text = "性别";
			// 
			// StudentAge
			// 
			this.StudentAge.AutoSize = true;
			this.StudentAge.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.StudentAge.Location = new System.Drawing.Point(429, 67);
			this.StudentAge.Name = "StudentAge";
			this.StudentAge.Size = new System.Drawing.Size(60, 24);
			this.StudentAge.TabIndex = 3;
			this.StudentAge.Text = "年龄";
			// 
			// StudentClass
			// 
			this.StudentClass.AutoSize = true;
			this.StudentClass.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.StudentClass.Location = new System.Drawing.Point(573, 67);
			this.StudentClass.Name = "StudentClass";
			this.StudentClass.Size = new System.Drawing.Size(60, 24);
			this.StudentClass.TabIndex = 4;
			this.StudentClass.Text = "班级";
			// 
			// StudentAddress
			// 
			this.StudentAddress.AutoSize = true;
			this.StudentAddress.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.StudentAddress.Location = new System.Drawing.Point(765, 67);
			this.StudentAddress.Name = "StudentAddress";
			this.StudentAddress.Size = new System.Drawing.Size(60, 24);
			this.StudentAddress.TabIndex = 5;
			this.StudentAddress.Text = "地址";
			// 
			// StudentPhone
			// 
			this.StudentPhone.AutoSize = true;
			this.StudentPhone.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.StudentPhone.Location = new System.Drawing.Point(1005, 67);
			this.StudentPhone.Name = "StudentPhone";
			this.StudentPhone.Size = new System.Drawing.Size(60, 24);
			this.StudentPhone.TabIndex = 6;
			this.StudentPhone.Text = "电话";
			// 
			// AddStudentMessages
			// 
			this.AddStudentMessages.Font = new System.Drawing.Font("宋体", 18F);
			this.AddStudentMessages.Location = new System.Drawing.Point(1287, 906);
			this.AddStudentMessages.Name = "AddStudentMessages";
			this.AddStudentMessages.Size = new System.Drawing.Size(118, 61);
			this.AddStudentMessages.TabIndex = 7;
			this.AddStudentMessages.Text = "添加学生";
			this.AddStudentMessages.UseVisualStyleBackColor = true;
			this.AddStudentMessages.Click += new System.EventHandler(this.AddStudentMessages_Click);
			// 
			// InquireMessages
			// 
			this.InquireMessages.Font = new System.Drawing.Font("宋体", 18F);
			this.InquireMessages.Location = new System.Drawing.Point(1468, 906);
			this.InquireMessages.Name = "InquireMessages";
			this.InquireMessages.Size = new System.Drawing.Size(118, 61);
			this.InquireMessages.TabIndex = 8;
			this.InquireMessages.Text = "查询学生";
			this.InquireMessages.UseVisualStyleBackColor = true;
			this.InquireMessages.Click += new System.EventHandler(this.InquireMessages_Click);
			// 
			// StudentMessages
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1738, 1001);
			this.Controls.Add(this.InquireMessages);
			this.Controls.Add(this.AddStudentMessages);
			this.Controls.Add(this.StudentPhone);
			this.Controls.Add(this.StudentAddress);
			this.Controls.Add(this.StudentClass);
			this.Controls.Add(this.StudentAge);
			this.Controls.Add(this.StudentSex);
			this.Controls.Add(this.StudentName);
			this.Controls.Add(this.StudentID);
			this.Name = "StudentMessages";
			this.Text = "地址";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentMessages_FormClosed);
			this.Load += new System.EventHandler(this.StudentMessages_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label StudentID;
		private System.Windows.Forms.Label StudentName;
		private System.Windows.Forms.Label StudentSex;
		private System.Windows.Forms.Label StudentAge;
		private System.Windows.Forms.Label StudentClass;
		private System.Windows.Forms.Label StudentAddress;
		private System.Windows.Forms.Label StudentPhone;
		private System.Windows.Forms.Button AddStudentMessages;
		private System.Windows.Forms.Button InquireMessages;
	}
}