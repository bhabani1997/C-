using System;

namespace Class
{
    class pratice
    {
        static void Main(string[] args)
        {
            Teams[] team = new Teams[2];
            team[0] = new Teams();
            team[1] = new Teams();
            for (int i = 0; i < 2; i++)
                team[i].team_details();
            players p1 = new players();
            p1.players_details();
            p1.display();
        }
    }
    class Teams
    {
        public string TeamName;
        public int NoOfPlayers;
      
       
       
        public void team_details()
        {
            Console.WriteLine("Enter the name of the team");
            TeamName = Console.ReadLine();
            Console.WriteLine("Enter the no of players of the team" + TeamName);
            NoOfPlayers =int.Parse(Console.ReadLine());
           
            for (int i = 0; i < NoOfPlayers; i++)
            {
                player[i].players_details();
            }
           
           
        }
    }

    class players
    {
        public string PlayerName;
        public int PlayerScore;
        public int TeamScore = 0;
        public int AverageScore = 0;
        int ManOfTheTeam=0;
        string name;
        string ManOfTheTeam1;
        string ManOfTheTeam2;
        string ManOfTheMatch;
        Teams t2 = new Teams();

        public void players_details()
        {
            Console.WriteLine("Enter the name of the players ");
            PlayerName = Console.ReadLine();
            Console.WriteLine("Enter the score of " + PlayerName);
            PlayerScore = Convert.ToInt32(Console.ReadLine());
           

        }
       
           public  void display()
        {
            TeamScore += PlayerScore;
            AverageScore =( (TeamScore) / (t2.NoOfPlayers));
            Console.WriteLine("The total score of " + t2.TeamName + TeamScore);
            Console.WriteLine("The average score of " + t2.TeamName + AverageScore);

        
            for(int i=0;i<t2.NoOfPlayers; i++)
            {
                if(t[0].PlayerScore>ManOfTheTeam)
                {
                    ManOfTheTeam=
                    ManOfTheTeam= t2.player[i].PlayerName;

                }
            }
            int ManOfTheTeam1 = Array.IndexOf(PlayerScore, x);
            Console.WriteLine("The man of the " + t2.TeamName + " is " + );
            int y = PlayerScore.Max();
            int ManOfTheTeam2 = Array.IndexOf(PlayerScore, y);
            Console.WriteLine("The man of the " +  + " is " + );
            if (ManOfTheTeam1 > ManOfTheTeam2)
                Console.WriteLine("The man of the match is " + ManOfTheTeam1);
            else
                Console.WriteLine("The man of the match is "  + ManOfTheTeam2);

        }

    }
}



