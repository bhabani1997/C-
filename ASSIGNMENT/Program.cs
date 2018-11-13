using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class person
    {
       public string name;
       public int age;
    }
    class doctor : person
    {
       public string specialization;
        public string availability;
       public void doctor_details()
        {
            Console.WriteLine("Enter the doctor name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age of the doctor");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the doctor specialization");
            specialization = Console.ReadLine();
            Console.WriteLine("Enter that doctor is available or not");
            availability = Console.ReadLine();
        }
        public void print_details()
        {
            Console.WriteLine(" name         " + "          age         " + "           specialization          " + "               availability");
            Console.WriteLine(  name           +           age            +              specialization           +                  availability);
        }
    }
    class patient : person
    {
        public string disease;
       public void patient_details()
        {
            Console.WriteLine("Enter the patient name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age of the patient");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the patient disease");
            disease = Console.ReadLine();
        }
        public void display_details()
        {
            Console.WriteLine(" name         " + "          age         " + "           disease          " );
            Console.WriteLine(  name           +            age           +             disease );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO NO1 HOSPITAL. WE ARE ALWAYS WITH YOU.");
            Console.WriteLine("PRESS 1 FOR DOCTOR DETAILS.");
            Console.WriteLine("PRESS 2 FOR PATIENT DETAILS.");
            Console.WriteLine("PRESS 3 EXIT.");
            int choice =Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        if (choice == 1)
                        {
                            doctor d = new doctor();
                            d.doctor_details();
                            doctor d1 = new doctor();
                            d1.doctor_details();
                            d.print_details();
                            d1.print_details();
                        }
                        break;
                           
                    }
                case 2:
                    {
                        if(choice==2)
                        {
                            patient p = new patient();
                            p.patient_details();
                            p.display_details();
                            patient p1 = new patient();
                            p1.patient_details();
                            p.display_details();
                            p1.display_details();
                        }
                        break;
                    }
                case 3:
                    break;
            }
            

          
           


        }
    }
}
