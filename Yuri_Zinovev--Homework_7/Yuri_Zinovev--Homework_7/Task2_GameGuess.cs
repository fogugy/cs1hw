using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
using Forms;

namespace Yuri_Zinovev__Homework_7
{
    public class Task2_GameGuess : HMTask
    {
        GuessForm _guessForm;

        public Task2_GameGuess()
        {
            Name = "GameGuess";
            Description = "blahblah";
            _guessForm = new GuessForm();
        }

        public override void Run()
        {
            _guessForm.OnClose = OnClose;

            base.Run(_guessForm);
        }
    }
}