using System;

namespace ConsoleApp1
{

    class Program
    {
        static string NameCourse1;
        static string NameCourse2;
        static string NameCourse3;

        static int FeesCourse1;
        static int FeesCourse2;
        static int FeesCourse3;

        static int DurationCourse1;
        static int DurationCourse2;
        static int DurationCourse3;




        /*
        static string[] DN = new string[3];
        static string[] DS = new string[3];
        static string[] DA = new string[3];
         static string[] PN = new string[3];
         static int[] PA = new int[3];
         static string[] PC = new string[3];
         static int[] PI = new int[7];
         */

        static void Main(string[] args)
        {

            /* DN[0] = "dembele";
            DN[1] = "umtitti";
            DN[2] = "suarez";

            DS[0] = "Cardiac electrophysiologist";
            DS[1] = "Allergist";
            DS[2] = "Colon and rectal surgeon";

            DA[0] = "A";
            DA[1] = "A";
            DA[2] = "A";

            PN[0] = "messi";
            PN[1] = "arthur ";
            PN[2] = "malcom";

            PA[0] = 31;
            PA[1] = 21;
            PA[2] = 22;

            PI[0] = 10;
            PI[1] = 8;
            PI[2] = 14;

            PC[0] = "cancer";
            PC[1] = "brain tumor";
            PC[2] = "fever";




            Console.WriteLine("WELCOME TO NO1 HOSPITAL.  WE ARE ALWAYS FOR YOU.");
            Console.WriteLine("PLEASE ENTER YOUR CHOICE");
            int choice;
            int new_choice = 0;
            int PID;
            Console.WriteLine("PRESS 1 FOR DOCTORS AVAILABILITY");
            Console.WriteLine("PRESS 2 FOR PATIENTS INFORMATION");
            Console.WriteLine("PRESS 3 EXIT");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine("PRESS 1 FOR HEART ISSUES");
                Console.WriteLine("Press 2 FOR ALLERGIES ISSUES");
                Console.WriteLine("PRESS 3 FOR RECTUM ISSUES");
                new_choice = Convert.ToInt32(Console.ReadLine());
                switch (new_choice)
                {
                    case 1:
                        Console.WriteLine("DOCTOR NAME                    DOCTOR SPECIALIZATION                             AVAILABILITY");
                        Console.WriteLine(DN[0] + "                           " + DS[0] + "                                          " + DA[0]);
                        break;
                    case 2:
                        Console.WriteLine("DOCTOR NAME                   DOCTOR SPECIALIZATION                              AVAILABILITY");
                        Console.WriteLine(DN[1] + "                           " + DS[1] + "                                          " + DA[1]);
                        break;
                    case 3:
                        Console.WriteLine("DOCTOR NAME                   DOCTOR SPECIALIZATION                              AVAILABILITY");
                        Console.WriteLine(DN[2] + "                           " + DS[2] + "                                          " + DA[2]);
                        break;
                    default:
                        Console.WriteLine("NO DOCTOR IS AVAILABLE");
                        break;
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("PRESS 1 FOR ALL PATIENTS DETAILS");
                Console.WriteLine("PRESS 2 FOR SPECIFIC PATIENTS DETAILS");
                Console.WriteLine("PRESS 3 FOR NEW PATIENT DETAILS");
                int PChoice = Convert.ToInt32(Console.ReadLine());

                 if (PChoice == 1)
                {
                    Console.WriteLine("PATIENT NAME            PATIENT AGE               PATIENT CONDITION             PATIENT ID");
                    Console.WriteLine(" ");
                    for (int i = 0; i <= 2; i++)
                    {

                        Console.WriteLine(PN[i] + "                     " + PA[i] + "                             " + PC[i] + "                        " + PI[i]);
                    }
                }
               else if (PChoice == 2)
                {
                    Console.WriteLine("TELL YOUR PATIENT ID");
                    PID = Convert.ToInt32(Console.ReadLine());
                    switch (PID)
                    {
                        case 1:
                            Console.WriteLine("PATIENT NAME            PATIENT AGE               PATIENT CONDITION                PATIENT ID");
                            Console.WriteLine(" ");
                            Console.WriteLine(PN[0] + "                     " + PA[0] + "                             " + PC[0] + "                        " + PI[0]);
                            break;
                        case 2:
                            Console.WriteLine("PATIENT NAME            PATIENT AGE                PATIENT CONDITION              PATIENT ID");
                            Console.WriteLine(" ");
                            Console.WriteLine(PN[1] + "                     " + PA[1] + "                             " + PC[1] + "                        " + PI[1]);
                            break;
                        case 3:
                            Console.WriteLine("PATIENT NAME          PATIENT AGE                 PATIENT CONDITION              PATIENT ID");
                            Console.WriteLine(" ");
                            Console.WriteLine(PN[2] + "                     " + PA[2] + "                             " + PC[2] + "                        " + PI[2]);
                            break;
                    }
                }
                else if (PChoice == 3)
                {
                    Console.WriteLine("ENTER THE NEW PATIENTS NAME");
                    string NP1 = Console.ReadLine();
                    Console.WriteLine("ENTER THE NEW PATIENTS AGE");
                    int NPA1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ENTER the PATIENTS CONDITION");

                    Console.WriteLine("PRESS 1 FOR HEART ISSUES");
                    Console.WriteLine("Press 2 FOR ALLERGIES ISSUES");
                    Console.WriteLine("PRESS 3 FOR RECTUM ISSUES");
                    new_choice = Convert.ToInt32(Console.ReadLine());
                    switch (new_choice)
                    {
                        case 1:
                            Console.WriteLine("                 PATIENT REPORT");
                            Console.WriteLine("   ");
                            Console.WriteLine("PATIENT NAME:    " + NP1);
                            Console.WriteLine("PATIENT AGE:     " + NPA1);
                            Console.WriteLine("PATIENT CONDITION  " + " HEART ISSUES");
                            Console.WriteLine("   ");
                            Console.WriteLine("DOCTOR NAME                   DOCTOR SPECIALIZATION                            AVAILABILITY");
                            Console.WriteLine("   ");
                            Console.WriteLine(DN[0] + "                           " + DS[0] + "                                          " + DA[0]);
                            break;
                        case 2:
                            Console.WriteLine("                 PATIENT REPORT");
                            Console.WriteLine("  ");
                            Console.WriteLine("PATIENT NAME:    " + NP1);
                            Console.WriteLine("PATIENT AGE:     " + NPA1);
                            Console.WriteLine("PATIENT CONDITION  ALLERGIES ISSUES");
                            Console.WriteLine("   ");
                            Console.WriteLine("DOCTOR's NAME                    DOCTOR SPECIALIZATION                         AVAILABILITY");
                            Console.WriteLine("   ");
                            Console.WriteLine(DN[1] + "                           " + DS[1] + "                                          " + DA[1]);
                            break;
                        case 3:
                            Console.WriteLine("                  PATIENT REPORT");
                            Console.WriteLine("  ");
                            Console.WriteLine("PATIENT NAME: " + NP1);
                            Console.WriteLine("PATIENT AGE:     " + NPA1);
                            Console.WriteLine("PATIENT CONDITION RECTUM ISSUES");
                            Console.WriteLine("   ");
                            Console.WriteLine("DOCTOR's NAME                       DOCTOR SPECIALIZATION                         AVAILABILITY");
                            Console.WriteLine("   ");
                            Console.WriteLine(DN[2] + "                           " + DS[2] + "                                          " + DA[2]);
                            break;
                        default:
                            Console.WriteLine("NO DOCTOR IS AVAILABLE");
                            break;
                    }
                }
                }
                else
                {
                    System.Environment.Exit(1);
                }
                Console.Read();
            }
        }
    }


}
    }*/

/* Console.WriteLine("WELCOME TO JSPIDERS");

Console.WriteLine("PRESS 1 FOR ENTERING THE COURSE DETAILS");
Console.WriteLine("PRESS 2 FOR DISPLAY THE EXISTING STUDENT DETAILS");
Console.WriteLine("PRESS 3 FOR ENQUIRY SECTION");
Console.WriteLine("PRESS 4 FOR EXIT");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
  case 1:

      Console.WriteLine("ENTER THE NAME OF FIRST COURSE");
      NameCourse1 = Console.ReadLine();
      Console.WriteLine("ENTER THE FEES OF FIRST COURSE");
      FeesCourse1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("ENTER THE DURATION OF FIRST COURSE");
      DurationCourse1 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("ENTER THE NAME OF SECOND COURSE");
      NameCourse2 = Console.ReadLine();
      Console.WriteLine("ENTER THE FEES OF SECOND COURSE");
      FeesCourse2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("ENTER THE  DURATION OF SECOND COURSE");
      DurationCourse2 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("ENTER THE NAME OF THIRD COURSE");
      NameCourse3 = Console.ReadLine();
      Console.WriteLine("ENTER THE FEES OF THIRD COURSE");
      FeesCourse3 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("ENTER THE DURATION OF THIRD COURSE");
      DurationCourse3 = Convert.ToInt32(Console.ReadLine());


      Console.WriteLine("ENIQUERY SECTION");
      Console.WriteLine("NAME OF THE COURSES" + "FEES OF THE COURSES" + "DURATION OF THE COURSES");
      Console.WriteLine(NameCourse1 + FeesCourse1 + DurationCourse1);
      Console.WriteLine(NameCourse2 + FeesCourse2 + DurationCourse2);
      Console.WriteLine(NameCourse3 + FeesCourse3 + DurationCourse3);

      break;
  case 2:
      Console.WriteLine("NameStudent1                 IdStudent1                     Course the student joined                           fees of the course");

      Console.WriteLine("messi           " + "         10            " + "                  AWS                 " + "                            15000");

      Console.WriteLine("authur          " + "          8            " + "                 AI                  " + "                             10000");

      Console.WriteLine("malcom          " + "          14           " + "                 ML                 " + "                            8000");
      break;
  case 3:
      Console.WriteLine("WELCOME TO ENQUIRY SECTION");

      Console.WriteLine("ENTER THE NAME OF STUDENT");
      string NameStudent1 = Console.ReadLine();
      Console.WriteLine("ENTER THE CONTACT NUMBER OF FIRST COURSE");
      int AgeStudent1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("ENTER THE COURSE WANT TO JOIN");
      string NameCourse4 = Console.ReadLine();

      if (NameCourse4 == NameCourse1)
      {
          Console.WriteLine(NameCourse1 + FeesCourse1 + DurationCourse1);
          Console.WriteLine(NameCourse2 + FeesCourse2 + DurationCourse2);
          Console.WriteLine(NameCourse3 + FeesCourse3 + DurationCourse3);
      }

      else if (NameCourse4 == NameCourse2)
      {
          Console.WriteLine(NameCourse1 + FeesCourse1 + DurationCourse1);
          Console.WriteLine(NameCourse2 + FeesCourse2 + DurationCourse2);
          Console.WriteLine(NameCourse3 + FeesCourse3 + DurationCourse3);
      }

      else if (NameCourse4 == NameCourse3)
      {
          Console.WriteLine(NameCourse1 + FeesCourse1 + DurationCourse1);
          Console.WriteLine(NameCourse2 + FeesCourse2 + DurationCourse2);
          Console.WriteLine(NameCourse3 + FeesCourse3 + DurationCourse3);
      }

      else
      {
          Console.WriteLine("Invalid Coursename");
          break;
      }
      break;
  case 4:
      break;


      break;

}
Console.ReadLine();
}
}
}   */


/*  Console.WriteLine("Enter the first team name");
string Team1 = Console.ReadLine();
Console.WriteLine("Enter the second team name");
string Team2 = Console.ReadLine();
Console.WriteLine("Enter the players name of Team1 ");
string[] Team1PlayersName = new string[5];
for (int i = 0; i < Team1PlayersName.Length; i++)
    Team1PlayersName[i] = Console.ReadLine();
Console.WriteLine("Enter the players name of Team2 ");
string[] Team2PlayersName = new string[5];
for (int i = 0; i < Team1PlayersName.Length; i++)
    Team2PlayersName[i] = Console.ReadLine();
int Scorecard1 = 0;
int[] Team1PlayersScore = new int[5];
for (int i = 0; i < Team1PlayersScore.Length; i++)
{
    Console.WriteLine("Enter the score of " + Team1PlayersName[i]);
    Team1PlayersScore[i] = Convert.ToInt32(Console.ReadLine());
    Scorecard1 = Scorecard1 + Team1PlayersScore[i];
}
int Scorecard2 = 0;
int[] Team2PlayersScore = new int[5];
for (int i = 0; i < Team2PlayersScore.Length; i++)
{
    Console.WriteLine("Enter the score of " + Team2PlayersName[i]);
    Team2PlayersScore[i] = Convert.ToInt32(Console.ReadLine());
    Scorecard2 = Scorecard2 + Team2PlayersScore[i];
}


Console.WriteLine(" The total score of " + Team1 + " is " + Scorecard1);



Console.WriteLine(" The total score of " + Team2 + " is " + Scorecard2);
if (Scorecard1 > Scorecard2)
    Console.WriteLine(Team1 + " won the match");
else if (Scorecard1 < Scorecard2)
    Console.WriteLine(Team2 + " won the match");
else
    Console.WriteLine("the match tied");
int x = Team1PlayersScore.Max();
int ManOfTheTeam1 = Array.IndexOf(Team1PlayersScore, x);
Console.WriteLine("The man of the " + Team1 + " is " + Team1PlayersName[ManOfTheTeam1]);
int y = Team2PlayersScore.Max();
int ManOfTheTeam2 = Array.IndexOf(Team2PlayersScore, y);
Console.WriteLine("The man of the " + Team2 + " is " + Team2PlayersName[ManOfTheTeam2]);
if (ManOfTheTeam1 > ManOfTheTeam2)
    Console.WriteLine("The man of the match is " + Team1PlayersName[ManOfTheTeam1]);
else
    Console.WriteLine("The man of the match is " + Team2PlayersName[ManOfTheTeam2]);
int AverageRunOfTeam1 = Scorecard1 / 5;
int AverageRunOfTeam2 = Scorecard2 / 5;
Console.WriteLine("Average run of " + Team1 + " is " + AverageRunOfTeam1);
Console.WriteLine("Average run of " + Team2 + " is " + AverageRunOfTeam2);
Console.Read();
}
}
}                  */







