namespace 产品检测 {
	partial class FormIndex {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.相机设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.作业设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.串口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
			this.cogRecordDisplay2 = new Cognex.VisionPro.CogRecordDisplay();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.IsOK = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.MessageList = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.相机设置ToolStripMenuItem,
            this.作业设置ToolStripMenuItem,
            this.串口设置ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 相机设置ToolStripMenuItem
			// 
			this.相机设置ToolStripMenuItem.Name = "相机设置ToolStripMenuItem";
			this.相机设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.相机设置ToolStripMenuItem.Text = "相机设置";
			this.相机设置ToolStripMenuItem.Click += new System.EventHandler(this.相机设置ToolStripMenuItem_Click);
			// 
			// 作业设置ToolStripMenuItem
			// 
			this.作业设置ToolStripMenuItem.Name = "作业设置ToolStripMenuItem";
			this.作业设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.作业设置ToolStripMenuItem.Text = "作业设置";
			this.作业设置ToolStripMenuItem.Click += new System.EventHandler(this.作业设置ToolStripMenuItem_Click);
			// 
			// 串口设置ToolStripMenuItem
			// 
			this.串口设置ToolStripMenuItem.Name = "串口设置ToolStripMenuItem";
			this.串口设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.串口设置ToolStripMenuItem.Text = "串口设置";
			this.串口设置ToolStripMenuItem.Click += new System.EventHandler(this.串口设置ToolStripMenuItem_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.cogRecordDisplay1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cogRecordDisplay2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 425);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// cogRecordDisplay1
			// 
			this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
			this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
			this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
			this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
			this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
			this.cogRecordDisplay1.Location = new System.Drawing.Point(3, 3);
			this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
			this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
			this.cogRecordDisplay1.Name = "cogRecordDisplay1";
			this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
			this.cogRecordDisplay1.Size = new System.Drawing.Size(260, 419);
			this.cogRecordDisplay1.TabIndex = 0;
			// 
			// cogRecordDisplay2
			// 
			this.cogRecordDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay2.ColorMapLowerRoiLimit = 0D;
			this.cogRecordDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
			this.cogRecordDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay2.ColorMapUpperRoiLimit = 1D;
			this.cogRecordDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cogRecordDisplay2.DoubleTapZoomCycleLength = 2;
			this.cogRecordDisplay2.DoubleTapZoomSensitivity = 2.5D;
			this.cogRecordDisplay2.Location = new System.Drawing.Point(269, 3);
			this.cogRecordDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
			this.cogRecordDisplay2.MouseWheelSensitivity = 1D;
			this.cogRecordDisplay2.Name = "cogRecordDisplay2";
			this.cogRecordDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay2.OcxState")));
			this.cogRecordDisplay2.Size = new System.Drawing.Size(260, 419);
			this.cogRecordDisplay2.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(535, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 419);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.IsOK);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 161);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "检测结果";
			// 
			// IsOK
			// 
			this.IsOK.BackColor = System.Drawing.Color.Red;
			this.IsOK.Location = new System.Drawing.Point(183, 61);
			this.IsOK.Name = "IsOK";
			this.IsOK.Size = new System.Drawing.Size(50, 50);
			this.IsOK.TabIndex = 6;
			this.IsOK.Text = "NG";
			this.IsOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(64, 106);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(76, 21);
			this.textBox3.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(64, 74);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(76, 21);
			this.textBox2.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(64, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(76, 21);
			this.textBox1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "良率：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "良品：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "总计：";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.MessageList);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 170);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(256, 246);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "运行信息";
			// 
			// MessageList
			// 
			this.MessageList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MessageList.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MessageList.FormattingEnabled = true;
			this.MessageList.ItemHeight = 21;
			this.MessageList.Location = new System.Drawing.Point(3, 17);
			this.MessageList.Name = "MessageList";
			this.MessageList.Size = new System.Drawing.Size(250, 226);
			this.MessageList.TabIndex = 0;
			// 
			// FormIndex
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormIndex";
			this.Text = "3";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIndex_FormClosing);
			this.Load += new System.EventHandler(this.FormIndex_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 相机设置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 作业设置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 串口设置ToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
		private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label IsOK;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox MessageList;
	}
}

