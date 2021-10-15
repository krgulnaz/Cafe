using System;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form1 : Form
    {
        private double summ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.soucesCheckBox.Enabled = false;
        }

        private void chickenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chickenCheckBox.Checked)
            {
                this.summ += 8;
            }
            else
            {
                this.summ -= 8;
            }
            this.priceLabel.Refresh();
        }

        private void friesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.friesCheckBox.Checked)
            {
                this.summ += 4;
                if (!this.soucesCheckBox.Enabled)
                    this.soucesCheckBox.Enabled = true;
            }
            else
            {
                this.summ -= 4;
                if (this.soucesCheckBox.Enabled)
                    this.soucesCheckBox.Enabled = false;
            }
            this.priceLabel.Refresh();
        }

        private void soucesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.soucesCheckBox.Checked)
                this.summ += 2;
            else
            {
                this.summ -= 2;
            }
            this.priceLabel.Refresh();
        }

        private void colaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.colaCheckBox.Checked)
            {
                this.summ += 5;
            }
            else
            {
                this.summ -= 5;
            }
            this.priceLabel.Refresh();
        }

        private void priceLabel_Paint(object sender, PaintEventArgs e)
        {
            this.priceLabel.Text = this.summ.ToString("C");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.chickenCheckBox.Checked && this.friesCheckBox.Checked &&
                this.soucesCheckBox.Checked && this.colaCheckBox.Checked)
            {
                MessageBox.Show("You ordered full kit\nWe give 10% discount to your full price\n" + "The price is " + (summ * 0.9).ToString("C"), "Cafe");
            }
            else
            {
                if (this.chickenCheckBox.Checked || this.friesCheckBox.Checked ||
              this.soucesCheckBox.Checked || this.colaCheckBox.Checked)
                {
                    MessageBox.Show("The price of the order is " + summ.ToString("C"), "Cafe");
                }
                else
                {
                    MessageBox.Show("You did not order anything!", "Cafe");
                }
            }
        }
    }
}
