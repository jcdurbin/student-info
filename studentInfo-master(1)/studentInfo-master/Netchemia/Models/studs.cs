using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Netchemia.Models
{
    public class studs
    {
        //Properties & Get-Set 
        [Key]   
        protected int studentId;
        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }

        protected string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        protected string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        protected int phoneNumber;
        public int PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        protected string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        protected string studentType;
        public string StudentType
        {
            get
            {
                return studentType;
            }
            set
            {
                string styp = value.ToLower();
                studentType = styp;
            }
        }


        //Student Object Constructor
        public studs(int sId, string fName, string lName, int pnum, string add, string sType)
        {
            studentId = sId;
            firstName = fName;
            lastName = lName;
            phoneNumber = pnum;
            address = add;
            studentType = sType;
        }
    
        //Action methods
        public void purchaseCafeteriaCredits()
        {        
            if (studentType == "graduate"){
            /**
                Buys Cafeteria Credits and adds them to the 
                cafeteriaCredits var using a specific grad method
            */
            }
            else if (studentType == "doctorate"){
            /**
                Buys Cafeteria Credits and adds them to the 
                cafeteriaCredits var using a specific dr method
            */
            } 
            else if (studentType == "undergrad"){
            /**
                Buys Cafeteria Credits and adds them to the 
                cafeteriaCredits var using a specific undergrad method
            */
            }
            else {
                //Return a msg saying invalid studentType
            }
    
        }

        public void retrieveTranscript()
        {
            if (studentType == "graduate"){
                //Retrieves the Student's Graduate Transcript
            }
            else if (studentType == "doctorate"){
                //Retrieves the Student's Doctorate Transcript
            } 
            else if (studentType == "undergrad"){
                //Retrieves the Student's Undergraduate Transcript
            }
            else {
                //Return a msg saying invalid studentType
            }
        }

        public void registerClass()
        {
            if (studentType == "graduate")
            {
                //Registers the Student for a Graduate Level Class
            }
            else if (studentType == "doctorate")
            {
                //Registers the Student for a Doctorate Level Class
            }
            else if (studentType == "undergrad")
            {
                //Registers the Student for an Undergraduate Level Class
            }
            else
            {
                //Return a msg saying invalid studentType
            }
        }
    }
}