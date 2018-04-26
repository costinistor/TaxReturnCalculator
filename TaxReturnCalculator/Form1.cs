using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxReturnCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioFixedFee.Checked = true;
            ChangeSymbol();
        }
        public string chooseMetCalc = "Gross Invoices";
        //int adminFeeCount;

        private void AddPay_Click(object sender, EventArgs e)
        {
            double sum;
            if(double.TryParse(inputPay.Text, out sum))
            {
                listInvoice.Items.Add(sum);
                invoicesCount.Text = "No: " + listInvoice.Items.Count.ToString();
            }            
            inputPay.Text = "";
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (var item in listInvoice.Items)
            {
                total += (double)item;
            }
            CalculInvoices(total);
        }

        void CalculInvoices(double total)
        {
            int adminFeeCount = listInvoice.Items.Count;
            double adminFee = 0;
            if(double.TryParse(inputAdminFee.Text, out adminFee))
            {
                adminFee = (radioFixedFee.Checked) ? adminFee * adminFeeCount : adminFee;
            }

            double ResultGross = 0; double ResultNet = 0; double ResultTax = 0;

            if (radioFixedFee.Checked)
            {
                if (chooseMetCalc == "Gross Invoices")
                {
                    total = total - adminFee;
                    ResultTax = total * 0.20;
                    ResultNet = total - ResultTax;
                    ResultGross = total + adminFee;
                }
                else if (chooseMetCalc == "Net Invoices")
                {
                    ResultTax = total * 0.25;
                    ResultGross = total + ResultTax + adminFee;
                    ResultNet = total;
                }
                else if (chooseMetCalc == "Tax Invoices")
                {
                    ResultGross = total * 5;
                    ResultNet = ResultGross - total;
                    ResultTax = total;
                }
            }else
            {
                if (chooseMetCalc == "Gross Invoices")
                {
                    ResultGross = total;
                    total = total - (total * (adminFee / 100));
                    ResultTax = total * 0.20;
                    ResultNet = total - ResultTax;
                }
                else if (chooseMetCalc == "Net Invoices")
                {
                    double tempPercentage = 100 - adminFee;
                    total = total * 100 / 80;
                    ResultGross = total * 100 / tempPercentage;
                    ResultTax = total * 0.20;
                    ResultNet = total - ResultTax;
                }
                else if (chooseMetCalc == "Tax Invoices")
                {
                    ResultGross = total * 5;
                    ResultNet = ResultGross - total;
                    ResultTax = total;
                }
            }                 

            ResultGross = Math.Round(ResultGross, 2);
            ResultNet = Math.Round(ResultNet, 2);
            ResultTax = Math.Round(ResultTax, 2);

            resultGross.Text = "£" + ResultGross.ToString();
            resultNet.Text = "£" + ResultNet.ToString();
            resultTax.Text = "£" + ResultTax.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var item = listInvoice.SelectedItem;
            listInvoice.Items.Remove(item);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listInvoice.Items.Clear();
        }

        private void chooseMet1_Click(object sender, EventArgs e)
        {
            chooseMetCalc = "Gross Invoices";
            selectMetCalc.Text = chooseMetCalc;
        }
        private void chooseMet2_Click(object sender, EventArgs e)
        {
            chooseMetCalc = "Net Invoices";
            selectMetCalc.Text = chooseMetCalc;
        }
        private void chooseMet3_Click(object sender, EventArgs e)
        {
            chooseMetCalc = "Tax Invoices";
            selectMetCalc.Text = chooseMetCalc;
        }

        

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            inputPay.Text += ".";
        }
        private void btnNum_0_Click(object sender, EventArgs e)
        {
            inputPay.Text += "0";
        }

        private void btnNum_1_Click(object sender, EventArgs e)
        {
            inputPay.Text += "1";
        }

        private void btnNum_2_Click(object sender, EventArgs e)
        {
            inputPay.Text += "2";
        }

        private void btnNum_3_Click(object sender, EventArgs e)
        {
            inputPay.Text += "3";
        }

        private void btnNum_4_Click(object sender, EventArgs e)
        {
            inputPay.Text += "4";
        }

        private void btnNum_5_Click(object sender, EventArgs e)
        {
            inputPay.Text += "5";
        }

        private void btnNum_6_Click(object sender, EventArgs e)
        {
            inputPay.Text += "6";
        }

        private void btnNum_7_Click(object sender, EventArgs e)
        {
            inputPay.Text += "7";
        }

        private void btnNum_8_Click(object sender, EventArgs e)
        {
            inputPay.Text += "8";
        }

        private void btnNum_9_Click(object sender, EventArgs e)
        {
            inputPay.Text += "9";
        }

        private void btnBackNum_Click(object sender, EventArgs e)
        {
            string newNumber = "";
            for (int i = 0; i < inputPay.Text.Length - 1; i++)
            {
                newNumber += inputPay.Text.Substring(i, 1);
            }
                inputPay.Text = newNumber;
        }

        private void radioPercentageFee_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSymbol();
        }

        private void radioFixedFee_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSymbol();
        }

        void ChangeSymbol()
        {
            if (radioFixedFee.Checked)
            {
                feeInputSimbol.Text = "£";
            }
            else
            {
                feeInputSimbol.Text = "%";
            }
        }



        private void btnOpenClients_Click(object sender, EventArgs e)
        {
            Clients myClients = new Clients();
            myClients.Show();
        }
    }
}
