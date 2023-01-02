using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace MOF_ATMS
{
    public partial class QRCode : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbMATMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public QRCode()
        {
            InitializeComponent();
            GenerateQR();
        }

        private void GenerateQR ()
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode("Siyabona Matwela Realeboa", QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBoxQR.Image = code.GetGraphic(50);

        }

        private void iconButtonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += PrintQr;
            pd.Document = pDoc;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                pDoc.Print();
            }
            this.Close();
        }

        private void PDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PrintQr (object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxQR.Image);
            pictureBoxQR.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBoxQR.Width, pictureBoxQR.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }
    }
}
