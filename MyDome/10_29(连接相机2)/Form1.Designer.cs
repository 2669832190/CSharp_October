﻿namespace _10_29_连接相机2_ {
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
			this.cogAcqFifoEditV21 = new Cognex.VisionPro.CogAcqFifoEditV2();
			this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
			this.SuspendLayout();
			// 
			// cogAcqFifoEditV21
			// 
			this.cogAcqFifoEditV21.Location = new System.Drawing.Point(564, 0);
			this.cogAcqFifoEditV21.MinimumSize = new System.Drawing.Size(489, 0);
			this.cogAcqFifoEditV21.Name = "cogAcqFifoEditV21";
			this.cogAcqFifoEditV21.Size = new System.Drawing.Size(538, 662);
			this.cogAcqFifoEditV21.SuspendElectricRuns = false;
			this.cogAcqFifoEditV21.TabIndex = 0;
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
			this.cogRecordDisplay1.Location = new System.Drawing.Point(2, 42);
			this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
			this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
			this.cogRecordDisplay1.Name = "cogRecordDisplay1";
			this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
			this.cogRecordDisplay1.Size = new System.Drawing.Size(566, 469);
			this.cogRecordDisplay1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(19, 517);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 80);
			this.button1.TabIndex = 2;
			this.button1.Text = "拍照";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(158, 517);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(111, 80);
			this.button2.TabIndex = 3;
			this.button2.Text = "开启实时显示";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button3.Location = new System.Drawing.Point(289, 518);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 79);
			this.button3.TabIndex = 4;
			this.button3.Text = "关闭实时显示";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button4.Location = new System.Drawing.Point(424, 518);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 79);
			this.button4.TabIndex = 5;
			this.button4.Text = "保存配置";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "相机画面显示";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1101, 663);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cogRecordDisplay1);
			this.Controls.Add(this.cogAcqFifoEditV21);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Cognex.VisionPro.CogAcqFifoEditV2 cogAcqFifoEditV21;
		private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
	}
}

