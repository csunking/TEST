using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Register
{
    public partial class register : Form
    {
        public register()
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
            string key;
            try
            {
                fAESEncryptor = new Elixis.AESEncryptor(GlobalVariables.ElixisPassWordString, Elixis.EncryptionOptions.AESBits.BITS256);
                key = fAESEncryptor.Decrypt(textBoxsqh.Text.Trim());
                fAESEncryptor = new Elixis.AESEncryptor(key, Elixis.EncryptionOptions.AESBits.BITS256);
                textBoxRegisterID.Text = fAESEncryptor.Encrypt("1");

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
    }
}
