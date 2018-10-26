using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DiceWare.Dictionary;

namespace DiceWare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //call checked method, match enabled of txt to chk
            chkSplit_CheckedChanged(null, null);
            ictrlNumberOfWords.Value = 5;

            //add possible enum values to ddl
            foreach (string name in Enum.GetNames(typeof(eDictionary)))
            {
                ddlDictionary.Items.Add(name);
            }
            ddlDictionary.SelectedIndex = 0;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                Clipboard.SetText(txtPassword.Text);
                //y this no work?
                //btnCopy.Text = "Copied!";
                //System.Threading.Thread.Sleep(1000);
                btnCopy.Text = "Copy";
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (ddlDictionary.SelectedIndex<0)
            {
                MessageBox.Show("No Dictionary Selected");
                return;
            }
            string password = string.Empty;
            char splitChar = new char();
            eDictionary dictionary = (eDictionary)Enum.Parse(typeof(eDictionary), ddlDictionary.SelectedItem.ToString());
            int.TryParse(ictrlNumberOfWords.Value.ToString(), out int amount);
            List<string> passwordWords = GetAmountOfWords(amount, dictionary);
            if (chkSplit.Checked)
            {
                if (txtSplitChar.Text.Length > 0)
                    splitChar = Convert.ToChar(txtSplitChar.Text);
                else
                {
                    MessageBox.Show("Can't split on an empty char.");
                    return;
                }
            }
            foreach (string s in passwordWords)
            {
                string word = s;
                if (chkUppercase.Checked)
                    word = FirstCharToUpper(s);
                if (splitChar != new char())
                    password += splitChar.ToString();
                password += word;
            }
            //cba stopping it from adding to beginning and end
            password = password.Substring(1, password.Length - 2);
            txtPassword.Text = password;
        }

        private void chkSplit_CheckedChanged(object sender, EventArgs e)
        {
            txtSplitChar.Enabled = chkSplit.Checked;
        }

        private void btnRndChar_Click(object sender, EventArgs e)
        {
            char c = RandomChar();
            if(txtPassword.Text.Length>1)
                txtPassword.Text += c;
        }

        private void btnRndNum_Click(object sender, EventArgs e)
        {
            char c = RandomNumber();
            if (txtPassword.Text.Length > 1)
                txtPassword.Text += c;
        }

        private void btnRndSymbol_Click(object sender, EventArgs e)
        {
            char c = RandomSymbol();
            if (txtPassword.Text.Length > 1)
                txtPassword.Text += c;
        }
    }
}
