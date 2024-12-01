using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Opc.Ua;
using Opc.Ua.Client;

namespace UaClient_Foundation
{
    public partial class UAClientCertForm : Form
    {
        /// <summary>    
        /// Form Construction
        /// </summary>
        #region Construction
        public UAClientCertForm(CertificateValidationEventArgs e)
        {
            InitializeComponent();
            eventArgs = e;

            //Get certificate meta data
            string[] row1 = new string[] { "Issuer Info", eventArgs.Certificate.IssuerName.Name };
            string[] row2 = new string[] { "Valid From", eventArgs.Certificate.NotBefore.ToString() };
            string[] row3 = new string[] { "Valit To", eventArgs.Certificate.NotAfter.ToString() };
            string[] row4 = new string[] { "Serial Number", eventArgs.Certificate.SerialNumber };
            string[] row5 = new string[] { "Signature Algorithm", eventArgs.Certificate.SignatureAlgorithm.FriendlyName};
            string[] row6 = new string[] { "Cipher Strength", eventArgs.Certificate.PublicKey.Key.KeySize.ToString()};
            string[] row7 = new string[] { "Thumbprint", eventArgs.Certificate.Thumbprint};
            string[] row8 = new string[] { "URI", eventArgs.Certificate.GetNameInfo(X509NameType.UrlName, false) };
            string[] row9 = new string[] { "Subject Alternative Name", "" };

            foreach (X509Extension ext in eventArgs.Certificate.Extensions)
            {
                AsnEncodedData asnData = new AsnEncodedData(ext.Oid, ext.RawData);
                String tempString = asnData.Format(true);
                if (tempString.Contains("URL") || tempString.Contains("IP") || tempString.Contains("DNS"))
                {
                    row9 = new string[] { "Subject Alternative Name", tempString };
                }
            }

            object[] rows = new object[] { row1, row2, row3, row4, row5, row6, row7, row8, row9};
            foreach (string[] rowArray in rows)
            {
                certGridView.Rows.Add(rowArray);
            }            
        }
        #endregion

        /// <summary> 
        /// Properties of this class
        /// </summary>
        #region Properties
        /// <summary> 
        /// Keeps a session with an UA server.
        /// </summary>
        CertificateValidationEventArgs eventArgs = null;
        #endregion

        /// <summary>
        /// Event handlers called by the UI
        /// </summary>
        #region UserInteractionsHandlers
        private void UAClientCertForm_VisibleChanged(object sender, EventArgs e)
        {
            certGridView.ClearSelection();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            eventArgs.Accept = true;

            if (permaCheckBox.Checked)
            {
                X509Store store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadWrite);
                store.Add(eventArgs.Certificate);
                store.Close();
            }
            Close();
        }
        private void rejectButton_Click(object sender, EventArgs e)
        {
            eventArgs.Accept = false;
            Close();
        }
        #endregion
    }
}
