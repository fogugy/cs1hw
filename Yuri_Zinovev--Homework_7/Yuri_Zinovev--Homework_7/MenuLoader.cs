using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms;
using MyLib;
using System.Windows.Forms;

namespace Yuri_Zinovev__Homework_7
{
    public class MenuLoader
    {
        List<HMTask> _tasks = new List<HMTask>();
        Forms.MainMenu _menu;

        public MenuLoader()
        {
            FillList();
        }

        public void Run()
        {
            LoadMenu();
        }

        void FillList()
        {
            _tasks = new List<HMTask>();
            _tasks.Add(new Task1_GameDoubler());
            _tasks.Add(new Task2_GameGuess());

            foreach (HMTask task in _tasks)
            {
                task.OnClose = OnGameClose;
            }
        }

        void LoadMenu()
        {
            _menu = new Forms.MainMenu(_tasks);
            _menu.StartGame = LoadGame;
            _menu.OnWindowClose = OnWindowClose;
            Application.Run(_menu);
        }

        void LoadGame(int index)
        {
            _menu.Hide();
            _tasks.ElementAt(index).Run();
        }

        void OnGameClose()
        {
            FillList();
            _menu.Show();
        }

        void OnWindowClose()
        {
            Application.Exit();
        }
    }
}
