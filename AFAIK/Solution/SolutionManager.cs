using Additionals.Interfaces;
using AFAIK.GUI;
using AFAIK.Solution.Serializable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFAIK.Solution
{
    public class SolutionManager : ICommands
    {

        private SolutionTemplate m_CurrentSolution = null;

        public SolutionTemplate CurrentSolution
        {
            get { return this.m_CurrentSolution; }
            internal set { this.m_CurrentSolution = value; }
        }

        public bool CreateNewSolution()
        {
            bool blnRet = false;
            frmSolutionManager solutionManager = new frmSolutionManager(this);
            solutionManager.ShowDialog();
            if (m_CurrentSolution != null)
            {
                blnRet = true;
            }
            return blnRet;
        }
    }
}
