namespace _10_29作业 {
	partial class Form1 {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cogAcqFifoEditV21 = new Cognex.VisionPro.CogAcqFifoEditV2();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV21)).BeginInit();
			this.SuspendLayout();
			// 
			// cogRecordDisplay1
			// 
			this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
			this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
			this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
			this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
			this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
			this.cogRecordDisplay1.Location = new System.Drawing.Point(12, 40);
			this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
			this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
			this.cogRecordDisplay1.Name = "cogRecordDisplay1";
			this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
			this.cogRecordDisplay1.Size = new System.Drawing.Size(591, 385);
			this.cogRecordDisplay1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(609, 309);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(185, 101);
			this.button1.TabIndex = 1;
			this.button1.Text = "点击进行拍照";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(25, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "相机画面显示";
			// 
			// cogAcqFifoEditV21
			// 
			this.cogAcqFifoEditV21.Location = new System.Drawing.Point(52, 66);
			this.cogAcqFifoEditV21.MinimumSize = new System.Drawing.Size(489, 0);
			this.cogAcqFifoEditV21.Name = "cogAcqFifoEditV21";
			this.cogAcqFifoEditV21.Size = new System.Drawing.Size(489, 71);
			this.cogAcqFifoEditV21.SuspendElectricRuns = false;
			this.cogAcqFifoEditV21.TabIndex = 3;
			this.cogAcqFifoEditV21.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cogAcqFifoEditV21);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cogRecordDisplay1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV21)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private Cognex.VisionPro.CogAcqFifoEditV2 cogAcqFifoEditV21;
	}
}

