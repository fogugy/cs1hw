using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLib
{
    public abstract class HMTask
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Action OnClose { get; set; }

        internal Form EnterForm { get; set; }

        virtual public void Run()
        {
            EnterForm.ShowDialog();
        }

        virtual public void Run(Form customForm)
        {
            EnterForm = customForm;
            EnterForm.ShowDialog();
        }
    }
}
