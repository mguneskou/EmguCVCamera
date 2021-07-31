namespace EmguCVCamera
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.camViewerPB1 = new CamViewerComponent.CamViewerPB();
            ((System.ComponentModel.ISupportInitialize)(this.camViewerPB1)).BeginInit();
            this.SuspendLayout();
            // 
            // camViewerPB1
            // 
            this.camViewerPB1.CrossMarkerColour = System.Drawing.Color.White;
            this.camViewerPB1.CrossMarkerEnabled = true;
            this.camViewerPB1.CrossMarkerThickness = 1F;
            this.camViewerPB1.EnableZoom = true;
            this.camViewerPB1.Location = new System.Drawing.Point(12, 12);
            this.camViewerPB1.MeasurerLineColour = System.Drawing.Color.Red;
            this.camViewerPB1.MeasurerLineThickness = 2F;
            this.camViewerPB1.MeasuringUnit = CamViewerComponent.MeasureUnit.Millimeter;
            this.camViewerPB1.Name = "camViewerPB1";
            this.camViewerPB1.PxToMMCalibration = 0.26315F;
            this.camViewerPB1.SetGraphicsQuality = CamViewerComponent.GraphicsQuality.High;
            this.camViewerPB1.Size = new System.Drawing.Size(642, 479);
            this.camViewerPB1.TabIndex = 0;
            this.camViewerPB1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 503);
            this.Controls.Add(this.camViewerPB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "VIS Camera";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camViewerPB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CamViewerComponent.CamViewerPB camViewerPB1;
    }
}

