using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
using Models;
using System.Windows.Forms;
using Forms;

namespace Yuri_Zinovev__Homework_7
{
    public class Task1_GameDoubler : HMTask
    {
        Doubler _doubler = new Doubler();
        DoublerForm _gameForm;

        public Task1_GameDoubler()
        {
            Name = "Doubler";
            Description = "doubler blah blah";
        }

        public override void Run()
        {
            StartGame();
            
            base.Run(_gameForm);
        }

        private void StartGame()
        {
            _gameForm = new DoublerForm(_doubler);
            _gameForm.OnClose = OnClose;
        }
    }
}
