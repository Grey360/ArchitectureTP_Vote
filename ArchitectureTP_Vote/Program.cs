using ArchitectureTP_Vote.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTP_Vote
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            var voters = new Voters();
            while (string.CompareOrdinal(input, "done") != 0)
            {
                voters.Add(new Voter(input = Console.ReadLine()));
            }
            foreach(Voter voter in voters){
                Console.WriteLine(voter);
            }
            List<string> usernames = new List<string>();

            GetUsername(usernames);

            while (!WhoIsVoting(usernames))
            {
                List<string> candidates = DisplayCandidates();
                string votes = TakeVotes();
            }
            
        }

        public static void GetUsername(List<string> username)
        {
            var name = "";
            while (string.CompareOrdinal(name, "done") != 0)
            {
                
                Console.WriteLine("Type a username in, please.\n(Use \"done\" to end this loop.\n)");
                username.Add(name = Console.ReadLine());
            }
        }

        public static bool WhoIsVoting(List<string> usernames)
        {
            var voter = Console.ReadLine();
            Console.WriteLine(usernames.Contains(voter) ? "You are signed up, please cast your vote." : "Please use a valid voter name...");
            return usernames.Contains(voter);
        }

        public static List<string> DisplayCandidates()
        {
            Console.WriteLine("List your candidates, end the task by typing \"exit\".");
            var array = new List<string> { };

            var userChoice = Console.ReadLine();
            while(string.CompareOrdinal(userChoice, "end") != 0)
            {
                array.Add(userChoice = Console.ReadLine());
                Console.WriteLine("(You can end the loop by typing \"end\".)");
            }
            Console.WriteLine("Your candidates are the following: \n\n");
            foreach(string choice in array)
            {
                Console.WriteLine("+ " + choice);
            }
            Console.ReadKey();
            return array;
         }

        public static string TakeVotes()
        {
            Console.WriteLine();

            var vote = Console.ReadLine();

            while(string.CompareOrdinal(vote, "exit") != 0)
            {
                vote = Console.ReadLine();
            }
            return vote;
        }

        public static void CheckVotes()
        {

        }
        public static string ConfirmVotes()
        {
            Console.WriteLine("Are you sure?\n\nConfirm by typing \"Y\".");
            return Console.ReadLine();
        }
    }
}
