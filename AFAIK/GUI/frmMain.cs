using AFAIK.Solution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFAIK.GUI
{
    public partial class frmMain : Form
    {
        internal CommandManager CommandManager = new CommandManager();

        public frmMain()
        {
            InitializeComponent();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandManager.Execute(Commands.CreateNewProject);
        }
    }
}
