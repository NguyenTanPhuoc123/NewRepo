using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace frmLogin
{
    public partial class frmQRCode : Form
    {
        public frmQRCode()
        {
            InitializeComponent();
        }

        private FilterInfoCollection device;
        private VideoCaptureDevice frame;

        private void frmQRCode_Load(object sender, EventArgs e)
        {
            device = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in device)
            {
                cboCamara.Items.Add(Device.Name);
            }
            cboCamara.SelectedIndex = 0;
            frame = new VideoCaptureDevice();
            StartCamara();
        }

        public void StartCamara()
        {
            frame = new VideoCaptureDevice(device[cboCamara.SelectedIndex].MonikerString);
            frame.NewFrame += new NewFrameEventHandler(frame_NewFrame);
            frame.Start();
        }

        private void frame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)picQR.Image);
            try
            {
                string decoded = result.ToString().Trim();

                if (decoded != "")
                {
                    timer1.Stop();
                    MessageBox.Show("Giao dịch thành công");
                    
                    if (frame.IsRunning == true)
                    {
                        frame.Stop();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void frmQRCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
