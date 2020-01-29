using System;
using System.Windows.Forms;

namespace BirthdayCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var dobStr = txtDateInput.Text;

                var ageCalc = new AgeCalculator(DateTime.Now);

                var age = ageCalc.CalculateAge(dobStr);

                lblAgeOutput.Text = age.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

                txtDateInput.Text = string.Empty;
            }

        }
    }
}
