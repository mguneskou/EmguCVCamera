using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;

namespace EmguCVCameraClassLibrary
{
    public class ClsCamera
    {
        VideoCapture Camera = null;
        Mat Frame;
        PictureBox Viewer = null;
        Image<Gray, Byte> ProcessedImage;
        Rectangle Zoom = new Rectangle();
        Size DefaultSize;

        public ClsCamera(PictureBox Viewer)
        {
            try
            {
                this.Viewer = Viewer;
                Frame = new Mat();
                Camera = new VideoCapture(0, VideoCapture.API.DShow);
                Camera.ImageGrabbed += Camera_ImageGrabbed;
                DefaultSize = new Size(Camera.Width, Camera.Height);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Rectangle ZoomRectangle { set { Zoom = value; } get { return Zoom; } }

        public Size GetDefaultSize { get { return DefaultSize; } }

        public void Start()
        {
            try
            {
                Camera.Start();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Camera_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                if (Camera != null && Camera.Ptr != IntPtr.Zero)
                {
                    Camera.Retrieve(Frame, 0);
                    Viewer.SizeMode = PictureBoxSizeMode.StretchImage;
                    Viewer.Image = ProcessFrame(Frame.Bitmap);
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        private Bitmap ProcessFrame(Bitmap Frm)
        {
            //Image<Bgr, byte> Img = new Image<Bgr, byte>(Frm);
            //ProcessedImage = Img.Convert<Gray, byte>();
            //Image<Gray, float> FinalImage = (ProcessedImage.Sobel(0, 1, 3).AbsDiff(new Gray(0.0)));
            //FinalImage.ROI = ZoomRectangle;
            //return FinalImage.ToBitmap();
            Image<Bgr, byte> Img = new Image<Bgr, byte>(Frm);
            Img.ROI = ZoomRectangle;
            return Img.ToBitmap();
        }

        private Image CropImage(Image img, Rectangle rect)
        {
            return ((Bitmap)img).Clone(rect, img.PixelFormat);
        }
    }
}