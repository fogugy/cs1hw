using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Forms
{
    public partial class DoublerForm : Form
    {
        public Doubler Doubler;
        public Action OnClose { get; set; }
        
        public DoublerForm(Doubler doubler)
        {
            Doubler = doubler;
            InitializeComponent();

            LoadModalInput();

            RenderData();
        }

        public void LoadModalInput()
        {
            string initialGoal = Doubler.Goal > 1 ? Doubler.Goal.ToString() : "100";
            ModalInput inputForm = new ModalInput(initialGoal);
            inputForm.OnOk = SetGoalNumber;
            inputForm.Validate = ValidateInput;
            inputForm.ShowDialog();
        }

        public void RenderData()
        {
            lblCurrent.Text = Doubler.Current.ToString();
            lblGoal.Text = Doubler.Goal.ToString();
            lblMoves.Text = Doubler.ActionsCounter.ToString();

            btnCancel.Enabled = Doubler.CanReturnState();

            if (Doubler.State == DoublerState.InProgress)
            {
                lblCurrent.ForeColor = Color.Green;
            }

            if (Doubler.State == DoublerState.Defeat)
            {
                lblCurrent.ForeColor = Color.Red;
                ShowDefeatDialog();
            }

            if (Doubler.State == DoublerState.Victory)
            {
                lblCurrent.ForeColor = Color.Gold;
                ShowVictoryDialog();
            }
        }

        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            Doubler.PlusOne();
            RenderData();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            Doubler.Double();
            RenderData();
        }

        private void btnResetToOne_Click(object sender, EventArgs e)
        {
            Doubler.ResetToOne();
            RenderData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Doubler.ReturnState();
            RenderData();
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            SetNewModel();
        }

        private void ShowDefeatDialog()
        {
            var dialogResponse = MessageBox.Show("Поражение. Попробуете снова?", "", MessageBoxButtons.OKCancel);
            if (dialogResponse == DialogResult.OK)
            {
                SetNewModel();
            }
            else
            {
                Close();
                OnClose();
            }
        }

        private void ShowVictoryDialog()
        {
            var dialogResponse = MessageBox.Show($"Победа за {lblMoves.Text} ходов! Попробуете снова?", "", MessageBoxButtons.OKCancel);
            if (dialogResponse == DialogResult.OK)
            {
                SetNewModel();
            }
            else
            {
                Close();
                OnClose();
            }
        }

        private void SetNewModel()
        {
            Doubler = new Doubler(Doubler.Goal);
            LoadModalInput();
            RenderData();
        }

        private bool ValidateInput(string sNumber)
        {
            int number = 1;
            bool success = int.TryParse(sNumber, out number);
            
            if(number <= 1 || number > 1000)
            {
                return false;
            }

            return success;
        }

        private bool SetGoalNumber(string sNumber)
        {
            Doubler.Goal = int.Parse(sNumber);
            return true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            OnClose();
        }
    }
}
