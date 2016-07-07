using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AFAIK.Solution;
using AFAIK.Solution.Serializable;
using System.Security.Cryptography;
using Additionals.Security;
using Additionals.Exceptions;

namespace AFAIK.GUI
{
    public partial class frmSolutionManager : Form
    {
        private SolutionManager solutionManager;

        public frmSolutionManager()
        {
            InitializeComponent();
        }

        public frmSolutionManager(SolutionManager solutionManager)
        {
            InitializeComponent();
            this.solutionManager = solutionManager;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                solutionManager.CurrentSolution = new SolutionTemplate(solutionNameTb.Text, new SolutionVersion(1, 0, 0, 0));

                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidateForm()
        {
            bool drResult = true;
            if (String.IsNullOrWhiteSpace(solutionNameTb.Text))
            {
                solutionNameTb.Focus();
                drResult = false;
            }
            return drResult;
        }
    }
}
