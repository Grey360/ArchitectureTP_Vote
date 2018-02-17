
namespace ArchitectureTP_Vote
{
    class Candidate
    {
        private string Name { get; set; }
        private string Party;

        public Candidate(string name, string party)
        {
            Name = name;
            Party = party;
        }
    }
}
