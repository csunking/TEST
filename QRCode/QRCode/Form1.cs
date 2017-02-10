using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QRCode
{
    public partial class Form1 : Form
    {
        DotNetBarcode bc = new DotNetBarcode();
        Image printImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.ptQRCode.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bc.Type = DotNetBarcode.Types.QRCode;
            bc.PrintCheckDigitChar = true;
        }

        private void ptQRCode_Paint(object sender, PaintEventArgs e)
        {
            bc.WriteBar(this.txtContent.Text.Trim(), 0, 0, this.ptQRCode.Width, this.ptQRCode.Height, e.Graphics);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string url = null;
            Bitmap b = new Bitmap(ptQRCode.Width, ptQRCode.Height);
            ptQRCode.DrawToBitmap(b,new Rectangle(0,0,ptQRCode.Width,ptQRCode.Height));
            SaveFileDialog sfd=new SaveFileDialog ();
            sfd.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            sfd.Filter="jpg图片|*.jpg|bmp图片|*.bmp";
            sfd.RestoreDirectory=true;
            sfd.Title="请选择要保存的位置";
            if(sfd.ShowDialog()==DialogResult.OK)
            {
            url=sfd.FileName;
            }
            printImage=b;
            if(url!=null)
            {
            b.Save(url);
            }



        }
    }
}
