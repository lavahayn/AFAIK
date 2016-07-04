namespace AFAIK.Solution
{
    public struct SolutionVersion
    {
        public SolutionVersion(int big, int minor, int rev, int build)
        {
            this.Big = big;
            this.Minor = minor;
            this.Revision = rev;
            this.Build = build;
        }

        int Big { get; set; }
        int Build { get; set; }
        int Minor { get; set; }
        int Revision { get; set; }

        public string GetVersion()
        {
            return $"{Big}.{Minor}.{Revision}.{Build}";
        }
    }
}