using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Register
{
    public partial class TommrowRegister : Form
    {
        public TommrowRegister()
        {
            InitializeComponent();
            this.skinEngine.SkinFile = "MacOS.ssk";
        }
        Elixis.AESEncryptor fAESEncryptor = null;
        private void register_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxsqh.Text.Trim() == "")
            {
                return;
            }
            int days = 0;
            if (comboBoxRegType.Text == "试用版")
            {                
                if (int.TryParse(textBoxDays.Text,out days))
                {
                    if (days <= 0 )
                    {
                        MessageBox.Show("试用版时注册天数不能小于0","注册");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("试用版时注册天数录入非法", "注册");
                    return;
                }
            }
            string key;
            try
            {
               
                key = textBoxsqh.Text.Trim();// fAESEncryptor.Decrypt(textBoxsqh.Text.Trim());
                fAESEncryptor = new Elixis.AESEncryptor(key, Elixis.EncryptionOptions.AESBits.BITS256);
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}|", textBoxHospitalName.Text);//医院名称
                sb.AppendFormat("{0}|", comboBoxRegType.Text);//注册类型
                sb.AppendFormat("{0}|", days.ToString());//注册天数
                sb.AppendFormat("{0}|", DateTime.Now.ToString("yyyy-MM-dd"));//注册日期                
                textBoxRegisterID.Text = fAESEncryptor.Encrypt(sb.ToString());
            }
            catch (Exception ex)
            {
                
               // throw;
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key;
            try
            {
              
                key = textBoxsqh.Text.Trim();// fAESEncryptor.Decrypt(textBoxsqh.Text.Trim());
                fAESEncryptor = new Elixis.AESEncryptor(key, Elixis.EncryptionOptions.AESBits.BITS256);
                string temp = textBoxRegisterID.Text;
                textBoxRegisterID.Text = fAESEncryptor.Decrypt(temp);
            }
            catch (Exception ex)
            {

                // throw;
            }
        }
    }
}
