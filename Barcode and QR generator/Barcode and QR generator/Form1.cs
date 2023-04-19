using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode_and_QR_generator
{
    public partial class Form1 : Form
    {
        private bool isGenerated = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isGenerated = true;
            resultPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            resultPictureBox.Image = barcode.Draw(barCodeTextBox.Text, 200);
        }

        private void generateButton2_Click(object sender, EventArgs e)
        {
            isGenerated = true;
            resultPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.CodeQrBarcodeDraw qrBarcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            resultPictureBox.Image = qrBarcode.Draw(qrCodeTextBox.Text, 100);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isGenerated)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                resultPictureBox.Image.Save(
                    path + "\\" + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg",
                    ImageFormat.Jpeg);
            }
        }
    }
}
