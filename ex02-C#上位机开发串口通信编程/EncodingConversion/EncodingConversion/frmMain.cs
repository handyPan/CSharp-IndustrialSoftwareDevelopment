using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncodingConversion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private byte[] stringToBytes(string myString)
        {
            Encoding srcEncoding = Encoding.GetEncoding("UTF-8");
            Encoding dstEncoding = Encoding.GetEncoding("gb2312");
            byte[] srcBytes = srcEncoding.GetBytes(myString);
            byte[] dstBytes = Encoding.Convert(srcEncoding, dstEncoding, srcBytes);
            return dstBytes;
        }

        private string bytesToString(byte[] myBytes)
        {
            Encoding srcEncoding = Encoding.GetEncoding("gb2312");
            Encoding dstEncoding = Encoding.GetEncoding("UTF-8");
            byte[] dstBytes = Encoding.Convert(srcEncoding, dstEncoding, myBytes);
            string dstString = dstEncoding.GetString(dstBytes);
            return dstString;
        }

        private void btn_convertGb2312ToUtf8_Click(object sender, EventArgs e)
        {
            byte[] resBytes = stringToBytes(txt_gb2312Src.Text);
            txt_utf8Dst.Text = "";
            foreach (byte myByte in resBytes)
            {
                string str = myByte.ToString("x").ToUpper();
                txt_utf8Dst.Text += "0x" + (str.Length == 1 ? "0" + str : str) + " ";
            }
        }

        private void btn_convertUtf8ToGb2312_Click(object sender, EventArgs e)
        {
            byte[] bytesToConvert = new byte[txt_utf8Src.Text.Length / 2];
            try
            {
                string utf8String = txt_utf8Src.Text;
                utf8String = utf8String.Replace("0x", string.Empty);
                utf8String = utf8String.Replace(" ", string.Empty);
                for (int i=0; i<utf8String.Length/2; i++)
                {
                    bytesToConvert[i] = Convert.ToByte(utf8String.Substring(i*2, 2), 16);
                }
                txt_gb2312Dst.Text = bytesToString(bytesToConvert);
            }
            catch (Exception)
            {
                MessageBox.Show("Data conversion error, please check the input", "Error");
            }
        }
    }
}
