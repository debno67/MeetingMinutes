using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week5Project
{
    class Program
    {
        static void Main(string[] args)
        {
       


            Console.Write("Meeting Minutes Management Software");  //HEADING SHOULD BE FIRST, NOT SURE HOW TO MAKE THAT HAPPEN.

            Console.WriteLine("1. Create Meeting \n2. View Team \n3. Exit"); //GIVE USER MENU OPTIONS
            string menu = Console.ReadLine();         
            

            switch(menu)  //USE SWITCH STATEMENTS SO USER CAN USE MENU NUMBER - SWITCH WILL CHANGE NUMBER TO TYPED MENU ITEM
            {
                case "1":

                    Console.WriteLine("Create Meeting");
                    break;

                case "2":

                    Console.WriteLine("View Team");
                    break;

                case "3":

                    Console.WriteLine("Exit");
                    break;

                default:

                    Console.WriteLine("unknown");
                    break;
            }
          
            Console.WriteLine("Enter name of person typing meeting minutes.");  //ASK USER FOR NAME OF PERSON TYPING MEETING MINUTES
            Console.WriteLine("Enter name of person leading the meeting.");  //ASK USER FOR NAME OF PERSON LEADING THE MEETING

            string date = "MMDDYY";    //SET VARIABLE FOR DATE/TIME
            Console.WriteLine("Enter date of meeting.");  //ASK USER FOR DATE OF MEETING
            DateTime time = DateTime.Parse(date);  //PARSE DATE CONVERTING STRING TO AN INT
            Console.ReadLine(); //READS USER INPUT           

            List<string> meetingType = new List<string>() { "Marketing Team", "All Team", "Admin. Team" };  //CREATE A LIST OF TEAMS
            Console.WriteLine("Enter meeting type.");  //ASK USER TO ENTER MEETING TYPE
            Console.ReadLine();  //READS USER RESPONSE

            string companyName = "Nolan Enterprises";
            string companyAddress = "5507 Hampstead";
            string cityStateZip = "Parma, OH  44129";
            string header = "Meeting Minutes";

            StreamWriter writer = new StreamWriter("Minutes.txt");  //creating text file
            using (writer)
            {
                writer.WriteLine(header + companyName + companyAddress + cityStateZip );
            }

        }
    }
}
