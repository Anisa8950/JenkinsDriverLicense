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
        private string _operator = "";

        public CaltulatorForm()
        {
            InitializeComponent();
            _metohds = new CalculatorMetods();
            operatorController = new OperatorController(_metohds);

            this.Size = new Size(440, 430);
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
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (double.TryParse(displayTB.Text, out double n))
            {
                if(_metohds.Accumulator == 0)
                {
                    _metohds.Accumulator = n;
                }
                if(_metohds.Accumulator != 0)
                {
                    equationL.Text = ""+ _metohds.Accumulator;                    
                }
                displayTB.Text = button.Text;
                _operator = button.Text;
                equationL.Text = n + " " + button.Text + " ";                
            }
        }

        private void equelB_Click(object sender, EventArgs e)
        {
            string result = Convert.ToString(_metohds.Accumulator);


            if(_operator!="log")
            {
                equationL.Text = equationL.Text + displayTB.Text;
                operatorController.Calculate(_operator, double.Parse(displayTB.Text));
            }
            else
            {
                operatorController.Calculate(_operator, 0);
            }
                       
            displayTB.Text = "" + _metohds.Accumulator;
            equationL.Text = equationL.Text + " = " + _metohds.Accumulator;
            historyLB.Items.Add(equationL.Text);
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            displayTB.Text = "";
            equationL.Text = "";
            _metohds.Clear();
        }


        private void history_Click(object sender, EventArgs e)
        {
            if(this.Size == new Size(675, 430))
            {
                this.Size = new Size(440, 430);
            }
            else
            {
                this.Size = new Size(675, 430);
            }
        }

        private void fortegn_Click(object sender, EventArgs e)
        {
            if(displayTB.Text != "")
            {
                displayTB.Text = "" + double.Parse(displayTB.Text) * -1;
            }            
        }

        private void valuesClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            
        }
    }
}

