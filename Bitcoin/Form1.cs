using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Bitcoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtcGetRates_Click(object sender, EventArgs e)
        {
            if (currencyCombo.SelectedItem != null)
            {
                string selectedCurrency = currencyCombo.SelectedItem.ToString();
                resultsLabel.Visible = true;
                resultTextBox.Visible = true;
                BitcoinRates bitcoin = GetRates();

                if (bitcoin != null)
                {
                    float result = 0.0f;
                    if (float.TryParse(amountOfCoinBox.Text, out float amount))
                    {
                        switch (selectedCurrency)
                        {
                            case "EUR":
                                result = amount * bitcoin.bpi.EUR.rate_float;
                                resultTextBox.Text = $"{result.ToString()} {bitcoin.bpi.EUR.code}";
                                break;
                            case "USD":
                                result = amount * bitcoin.bpi.USD.rate_float;
                                resultTextBox.Text = $"{result.ToString()} {bitcoin.bpi.USD.code}";
                                break;
                            case "GBP":
                                result = amount * bitcoin.bpi.GBP.rate_float;
                                resultTextBox.Text = $"{result.ToString()} {bitcoin.bpi.GBP.code}";
                                break;
                            default:
                                MessageBox.Show("Invalid currency selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to fetch Bitcoin rates. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a currency.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void amountOfCoinBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(response);
            }

            return bitcoin;
        }
    }
}
