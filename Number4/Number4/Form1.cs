using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number4
{
    public partial class Form1 : Form
    {

        String UserName= "";
        String SSN = "";
        String Pay = "";
        String HoursWorked = "";
        Decimal PayD = 0;
        Decimal HoursWorkedD = 0;
        Decimal GP = 0;
        Decimal Tax1 = 0;
        Decimal Tax2 = 0;
        Decimal NetPay = 0;
        String Tax1String = "";
        String Tax2String = "";
        String GPString = "";
        String NetPayString = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void SSNLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
        }

        private void PayTextBox_TextChanged(object sender, EventArgs e)
        {
            Pay = PayTextBox.Text;
        }

        private void HoursWorkedTextBox_TextChanged(object sender, EventArgs e)
        {
            HoursWorked = HoursWorkedTextBox.Text;
        }

        private void CalculateBotton_Click(object sender, EventArgs e)
        {
            //Gross Pay//
            PayD = System.Convert.ToDecimal(Pay);
            HoursWorkedD = System.Convert.ToDecimal(HoursWorked);
            GP = PayD * HoursWorkedD;
            GPString = System.Convert.ToString(GP);

            //Federal withholding tax//

            Tax1 = GP * (Decimal)0.15 ;
            Tax1String = System.Convert.ToString(Tax1);

            //State withholding tax//

            Tax2 = GP * (Decimal)0.05;
            Tax2String = System.Convert.ToString(Tax2);

            //Net pay//

            NetPay = GP - (Tax1 + Tax2);

            NetPayString = System.Convert.ToString(NetPay);

            NameResult.Text = "Dear " + UserName + " with SSN number " + SSN;
            Result1Label.Text = "Gross Pay $" + GPString;
            Result2Label.Text = "Federal withholding tax $" + Tax1String;
            Result3Label.Text = "State withholding tax $" + Tax2String;
            Result4Label.Text = "Net Pay $" + NetPayString;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Result4Label_Click(object sender, EventArgs e)
        {

        }

        private void SSNTextBox_TextChanged(object sender, EventArgs e)
        {
            SSN = SSNTextBox.Text;
        }
    }
    }

