using Additionals.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AFAIK.Solution.Serializable
{
    [Serializable]
    [DebuggerDisplay("Name = {this.SolutionName}, Hash = {this.SolutionHash}, Version = {this.SolutionVersion}")]
    public class SolutionTemplate
    {
        public SolutionTemplate(string solutionName, SolutionVersion solutionVersion)
        {
            this.SolutionName = solutionName;
            this.SolutionVersion = solutionVersion;
        }

        public string SolutionName { get; set; }
        public string SolutionHash
        {
            get
            {

                using (MD5 md5Hash = MD5.Create())
                {
                 return AFAIKHash.GetMd5Hash(md5Hash, this.SolutionName);
                }
            }
        }
        public SolutionVersion SolutionVersion { get; set; }
        public string TemporaryContent { get; set; }
    }
}
