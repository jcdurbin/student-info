using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netchemia.Model
{
    public class Client
    {
        public abstract class Student
        {
            //Properties
            protected int StudentId { get; set; }
            protected string FirstName { get; set; }
            protected string LastName { get; set; }
            protected string PhoneNumber { get; set; }
            protected string Address { get; set; }
            protected string StudentType { get; set; }
            protected bool AreActive { get; set; }

            //Action Methods
            public void purchaseCafeteriaCredits(int numOfCreds)
            {
                //Buys Cafeteria Credits
            }
            public void retrieveTranscript()
            {
                //Retrieves the Student's  Transcript
            }
            public void registerClass()
            {
                //Registers the Student for a Class
            }
        }

        public class Graduate : Student
        {
            //Override Student Action Methods
            public void purchaseCafeteriaCredits(int numOfCreds)
            {
                //Buys Cafeteria Credits for Grad Student
            }
            public void retrieveTranscript()
            {
                //Retrieves the Student's Graduate Transcript
            }
            public void registerClass()
            {
                //Registers the Student for a Graduate Level Class
            }
            
        }
        
        public class Undergraduate : Student
        {
            //Override Student Action Methods
            public void purchaseCafeteriaCredits(int numOfCreds)
            {
                //Buys Cafeteria Credits for Undergrad Student
            }
            public void retrieveTranscript()
            {
                //Retrieves the Student's Undergrad Transcript
            }
            public void registerClass()
            {
                //Registers the Student for an Undergrad Level Class
            }
        }

        public class Doctorate : Student 
        {
            //Override Student Action Methods
            public void purchaseCafeteriaCredits(int numOfCreds)
            {
                //Buys Cafeteria Credits for Doctorate Student
            }
            public void retrieveTranscript()
            {
                //Retrieves the Student's Doctorate Transcript
            }
            public void registerClass()
            {
                //Registers the Student for a Doctorate Level Class
            }
        }
    }
}
