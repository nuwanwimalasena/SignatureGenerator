using System;
using System.Text;
using System.Windows.Forms;

namespace GloRemit.Rsp.SignGenerator
{
    public partial class SignatureGeneratorForm : Form
    {
        public SignatureGeneratorForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecretKey.Text.Trim()))
            {
                MessageBox.Show("Please make sure the secret key is not empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StringBuilder sbInput = new StringBuilder();

                switch (tabActionType.SelectedIndex)
                {
                    case 0: // Validation
                        sbInput.Append(txtUID.Text.Trim());
                        sbInput.Append(txtTransID.Text.Trim());
                        sbInput.Append(txtSIDNum.Text.Trim());
                        sbInput.Append(txtbAccType.Text.Trim());
                        sbInput.Append(txtbAccNum.Text.Trim());
                        sbInput.Append(txtbIssuerCode.Text.Trim());
                        break;
                    case 1: // Do_Transfer
                        sbInput.Append(txtTUID.Text.Trim());
                        sbInput.Append(txtTTransID.Text.Trim());
                        sbInput.Append(trxTTrxValue.Text.Trim());
                        sbInput.Append(txtTsCurr.Text.Trim());
                        sbInput.Append(txtTsIDNum.Text.Trim());
                        sbInput.Append(txtTsFirstName.Text);
                        sbInput.Append(txtTsLastName.Text);
                        sbInput.Append(txtTbCurrency.Text.Trim());
                        sbInput.Append(txtTbIDNum.Text.Trim());
                        sbInput.Append(txtTbFirstName.Text);
                        sbInput.Append(txtTbLastName.Text);
                        sbInput.Append(txtTbAccType.Text.Trim());
                        sbInput.Append(txtTbAccNum.Text.Trim());
                        sbInput.Append(txtTbIssuerCOde.Text.Trim());
                        break;
                    case 2: // Bill_Inquiry
                        sbInput.Append(txtBIUID.Text.Trim());
                        sbInput.Append(txtBITransID.Text.Trim());
                        sbInput.Append(txtBIsIDNum.Text.Trim());
                        sbInput.Append(txtBIbAccNum.Text.Trim());
                        sbInput.Append(txtBIbIssuerCode.Text.Trim());
                        break;
                    case 3: // Bill_Payment
                        sbInput.Append(txtBPUID.Text.Trim());
                        sbInput.Append(txtBPTransID.Text.Trim());
                        sbInput.Append(txtBPTrxValue.Text.Trim());
                        sbInput.Append(txtBPsCurrency.Text.Trim());
                        sbInput.Append(txtBPsIDNum.Text.Trim());
                        sbInput.Append(txtBPsFirstName.Text.Trim());
                        sbInput.Append(txtBPsLastName.Text.Trim());
                        sbInput.Append(txtBPbCurrency.Text.Trim());
                        sbInput.Append(txtBPbAccNum.Text.Trim());
                        sbInput.Append(txtBPbIssuerCode.Text.Trim());
                        break;
                }

                sbInput.Append(txtSecretKey.Text.Trim());

                GenerateRspSign(sbInput.ToString());
                Logger.Log(string.Format("GloRemit Generated Data={0}", sbInput.ToString()), LogType.INFO);
            }
        }

        /// <summary>
        /// Generate RSP Signature
        /// </summary>
        /// <param name="input">The input string for signature generation</param>
        private void GenerateRspSign(string input)
        {
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider md5SP = new System.Security.Cryptography.MD5CryptoServiceProvider();
                Byte[] data = md5SP.ComputeHash(Encoding.ASCII.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                    sBuilder.Append(data[i].ToString("x2"));

                txtRspSignature.Text = sBuilder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when generating signature::" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Log(string.Format("GenerateRspSign Exception::{0}", ex.ToString()), LogType.ERROR);
            }
        }
    }
}
