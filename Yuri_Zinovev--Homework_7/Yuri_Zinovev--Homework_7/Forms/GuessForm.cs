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
    public partial class GuessForm : Form
    {
        int Goal { get; set; }
        int Counter { get; set; }

        public Action OnClose { get; set; }

        public GuessForm()
        {
            InitializeComponent();
            StartNew();
        }

        private void StartNew()
        {
            Goal = new Random().Next(0, 101);
            Counter = 0;
            input.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inputNumber = 0;
            bool parsed = int.TryParse(input.Text, out inputNumber);

            if (!parsed)
            {
                input.Text = "";
                return;
            }

            Counter++;

            if (parsed && inputNumber == Goal)
            {
                var dialogResponse = MessageBox.Show($"Победа за {Counter} ходов! Попробуете снова?", "", MessageBoxButtons.OKCancel);
                if (dialogResponse == DialogResult.OK)
                {
                    StartNew();
                }
                else
                {
                    Close();
                    OnClose();
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            OnClose();
        }
    }
}
