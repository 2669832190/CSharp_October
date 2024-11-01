namespace 学生管理
{
    partial class Form1
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
            this.idlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.agelabel = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.classlabel = new System.Windows.Forms.Label();
            this.dislabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("宋体", 15F);
            this.idlabel.Location = new System.Drawing.Point(12, 49);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(49, 20);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "学号";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("宋体", 15F);
            this.namelabel.Location = new System.Drawing.Point(147, 49);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(49, 20);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "姓名";
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Font = new System.Drawing.Font("宋体", 15F);
            this.agelabel.Location = new System.Drawing.Point(236, 49);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(49, 20);
            this.agelabel.TabIndex = 2;
            this.agelabel.Text = "年龄";
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("宋体", 15F);
            this.genderlabel.Location = new System.Drawing.Point(316, 49);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(49, 20);
            this.genderlabel.TabIndex = 3;
            this.genderlabel.Text = "性别";
            // 
            // classlabel
            // 
            this.classlabel.AutoSize = true;
            this.classlabel.Font = new System.Drawing.Font("宋体", 15F);
            this.classlabel.Location = new System.Drawing.Point(427, 49);
            this.classlabel.Name = "classlabel";
            this.classlabel.Size = new System.Drawing.Size(49, 20);
            this.classlabel.TabIndex = 4;
            this.classlabel.Text = "班级";
            // 
            // dislabel
            // 
            this.dislabel.AutoSize = true;
            this.dislabel.Font = new System.Drawing.Font("宋体", 15F);
            this.dislabel.Location = new System.Drawing.Point(634, 49);
            this.dislabel.Name = "dislabel";
            this.dislabel.Size = new System.Drawing.Size(49, 20);
            this.dislabel.TabIndex = 5;
            this.dislabel.Text = "地址";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("宋体", 15F);
            this.phonelabel.Location = new System.Drawing.Point(839, 49);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(89, 20);
            this.phonelabel.TabIndex = 6;
            this.phonelabel.Text = "联系方式";
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(12, 72);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(1450, 450);
            this.infoBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 20F);
            this.button1.Location = new System.Drawing.Point(891, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "添加学生";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 20F);
            this.button2.Location = new System.Drawing.Point(1084, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "查询信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 638);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.dislabel);
            this.Controls.Add(this.classlabel);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Label classlabel;
        private System.Windows.Forms.Label dislabel;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Panel infoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

