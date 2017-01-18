using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

namespace Forms
{
    public delegate void StartGame(int index);

    public partial class MainMenu : Form
    {
        public StartGame StartGame { get; set; }
        public Action OnWindowClose { get; set; }

        List<HMTask> _gamesList = new List<HMTask>();

        public MainMenu(List<HMTask> gamesList)
        {
            InitializeComponent();

            _gamesList = gamesList;

            RenderList();
        }

        public void RenderList()
        {
            foreach (HMTask task in _gamesList)
            {
                listGames.Items.Add(task.Name);
            }
        }

        private void listGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listGames.SelectedIndex;

            txbDescription.Text = _gamesList.ElementAt(selectedIndex).Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = listGames.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            StartGame(selectedIndex);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            OnWindowClose();
        }
    }
}
