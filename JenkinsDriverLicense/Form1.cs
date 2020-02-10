using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JenkinsDriverLicense
{
    public partial class CaltulatorForm : Form
    {
        private CalculatorMetods _metohds;
        private OperatorController operatorController;

        public int _result { get; set; }
        public string _operator { get; set; }

        public CaltulatorForm()
        {
            InitializeComponent();
            _metohds = new CalculatorMetods();
            operatorController = new OperatorController(_metohds);
            this.Size = new Size(480, 400);
            equationL.Text = "";

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (displayTB.Text == _operator)
            {
                displayTB.Text = "";
                displayTB.Text = displayTB.Text + button.Text;
            }
            else
            {
                displayTB.Text = displayTB.Text + button.Text;
            }
            equationL.Text = equationL.Text + button.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (int.TryParse(displayTB.Text, out int n))
            {
                displayTB.Text = button.Text;
                _operator = button.Text;
                equationL.Text = equationL.Text + " " + button.Text + " ";
            }
        }

        private void equelB_Click(object sender, EventArgs e)
        {

        }

        private void deleteB_Click(object sender, EventArgs e)
        {

        }

        private void clearB_Click(object sender, EventArgs e)
        {
            displayTB.Text = "";
        }

        private void history_Click(object sender, EventArgs e)
        {
            if(this.Size == new Size(700, 400))
            {
                this.Size = new Size(480, 400);
            }
            else
            {
                this.Size = new Size(700, 400);
            }
        }
    }
}

