using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;
using Forms;

namespace Yuri_Zinovev__Homework_7
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            MenuLoader menuLoader = new MenuLoader();
            menuLoader.Run();
        }
    }
}
