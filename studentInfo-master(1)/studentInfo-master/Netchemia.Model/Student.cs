using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netchemia.Model
{
    public class Student
    {
        //Properties
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string StudentType { get; set; }
        public bool AreActive { get; set; }

        //Action methods
        public void purchaseCafeteriaCredits(int numOfCreds)
        {
            /**
            if (StudentType == "graduate")
            {
             
                    Buys Cafeteria Credits using a specific grad method
             
            }
            else if (StudentType == "doctorate")
            {
             
                    Buys Cafeteria Credits using a specific dr method
             
            }
            else if (StudentType == "undergrad")
            {
                    Buys Cafeteria Credits using a specific undergrad method
            }
            else
            {
                //Return a msg saying invalid studentType
            }
            */
        }
        public void retrieveTranscript()
        {
            /**
            if (StudentType == "graduate")
            {
                //Retrieves the Student's Graduate Transcript
            }
            else if (StudentType == "doctorate")
            {
                //Retrieves the Student's Doctorate Transcript
            }
            else if (StudentType == "undergrad")
            {
                //Retrieves the Student's Undergraduate Transcript
            }
            else
            {
                //Return a msg saying invalid studentType
            }
            */
        }
        public void registerClass()
        {
            /**
            if (StudentType == "graduate")
            {
                //Registers the Student for a Graduate Level Class
            }
            else if (StudentType == "doctorate")
            {
                //Registers the Student for a Doctorate Level Class
            }
            else if (StudentType == "undergrad")
            {
                //Registers the Student for an Undergraduate Level Class
            }
            else
            {
                //Return a msg saying invalid studentType
            }
            */
        }

    }
}
