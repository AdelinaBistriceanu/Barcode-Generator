using Zen;
using System.Drawing.Imaging;

namespace BarcodeGenerator2
{
    public partial class Form1 : Form
    {
        bool isGenerated=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isGenerated = true;
            pic.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pic.Image = barcode.Draw(txtEncode.Text, 200);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isGenerated)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                pic.Image.Save(path + "\\" + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg", ImageFormat.Jpeg);
            }
        }
    }
}