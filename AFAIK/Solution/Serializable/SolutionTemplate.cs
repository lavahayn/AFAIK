using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFAIK.Solution.Serializable
{
    [Serializable]
    [DebuggerDisplay("Name = ")]
    public class SolutionTemplate
    {
        public SolutionTemplate(string solutionName, string solutionHash, SolutionVersion solutionVersion)
        {
            this.SolutionHash = solutionHash;
            this.SolutionName = solutionName;
            this.SolutionVersion = solutionVersion;
        }

        public string SolutionName { get; set; }
        public string SolutionHash { get; set; }
        public SolutionVersion SolutionVersion { get; set; }
    }
}
