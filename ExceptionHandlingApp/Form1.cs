using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandlingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtDivident.Text.Equals(" ") || txtDivisor.Text.Equals(" "))
                {
                    throw new ArgumentNullException();
                }

                double divident = double.Parse(txtDivident.Text);
                double divisor = double.Parse(txtDivisor.Text);
                double quotient = divident / divisor;

                if (divisor == 0)
                {
                    throw new DivideByZeroException("Cannot be devided by 0");
                    
                }
                if (divident < 100 || divisor < 100)
                {
                    throw new ValueLessThanHundredException();

                }

                MessageBox.Show(quotient.ToString());
            }

            catch(ArgumentNullException err)
            {
                Console.WriteLine("Value should not be empty or null");
            }
            catch (DivideByZeroException err)
            {

                MessageBox.Show(err.Message);

            }
            catch(ValueLessThanHundredException err)
            {
                MessageBox.Show(err.Message);

            }
           catch(FormatException err)
            {
                txtDivident.Text = "";
                txtDivisor.Text = "";
            }

        }
    }
}

