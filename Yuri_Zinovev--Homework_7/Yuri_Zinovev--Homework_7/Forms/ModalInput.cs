using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ModalInput : Form
    {
        public Predicate<string> OnOk { get; set; }
        public Predicate<string> Validate { get; set; }

        public ModalInput()
        {
            InitializeComponent();
            lblError.Hide();
        }
        public ModalInput(string initialValue)
            :this()
        {
            inputNumber.Text = initialValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnValue();
        }

        private void inputNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReturnValue();
            }
        }

        private void ReturnValue()
        {
            if(Validate(inputNumber.Text))
            {
                OnOk(inputNumber.Text);
                Close();
            }
            else
            {
                lblError.Show();
            }
        }
    }
}
