
namespace ArchitectureTP_Vote
{
    /// <summary>
    /// The Voter class defines what a voter can do.
    /// </summary>
    class Voter
    {
        string Name;
        int NumberOfCast;

        public Voter(string name)
        {
            Name = name;
        }

        public void Vote()
        {
            NumberOfCast++;
        }
    }
}
