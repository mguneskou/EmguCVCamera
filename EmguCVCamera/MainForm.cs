using System;
using System.Windows.Forms;
using EmguCVCameraClassLibrary;

namespace EmguCVCamera
{
    public partial class MainForm : Form
    {
        ClsCamera Cam = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Cam = new ClsCamera(camViewerPB1);
                camViewerPB1.EventTriggerZoom += CamViewerPB1_EventTriggerZoom;
            }
            catch (Exception ex)
            {
                camViewerPB1.ErrorMessage = ex.Message;
            }
            try
            {
                if (Cam != null)
                {
                    Cam.Start();
                }
            }
            catch (Exception ex)
            {
                camViewerPB1.ErrorMessage = ex.Message;
            }
        }

        private void CamViewerPB1_EventTriggerZoom()
        {
            try
            {
                Cam.ZoomRectangle = camViewerPB1.ZoomAction.ZoomRectangle;
            }
            catch (Exception ex)
            {
                camViewerPB1.ErrorMessage = ex.Message;
            }
        }
    }
}