namespace TB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cogRecordDisplay2 = new Cognex.VisionPro.CogRecordDisplay();
            this.label1 = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).BeginInit();
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
            this.cogRecordDisplay1.Location = new System.Drawing.Point(12, 12);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(476, 539);
            this.cogRecordDisplay1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "拍照";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "运行TB测量距离";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cogRecordDisplay2
            // 
            this.cogRecordDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay2.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay2.Location = new System.Drawing.Point(615, 12);
            this.cogRecordDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay2.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay2.Name = "cogRecordDisplay2";
            this.cogRecordDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay2.OcxState")));
            this.cogRecordDisplay2.Size = new System.Drawing.Size(462, 539);
            this.cogRecordDisplay2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "宽度:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(535, 176);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(11, 12);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 563);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cogRecordDisplay2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cogRecordDisplay1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label widthLabel;
    }
}

