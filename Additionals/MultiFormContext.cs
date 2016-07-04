using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additionals
{
    public class MultiFormContext : ApplicationContext
    {
        private int nOpenForms;
        public MultiFormContext(params Form[] forms)
        {
            nOpenForms = forms.Length;

            foreach (Form form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    //When we have closed the last of the "starting" forms, 
                    //end the program.
                    if (Interlocked.Decrement(ref nOpenForms) == 0)
                    {
                        ExitThread();
                    }
                };

                form.Show();
            }
        }
    }
}
