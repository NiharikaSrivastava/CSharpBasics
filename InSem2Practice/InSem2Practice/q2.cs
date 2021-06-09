/*
//Q2. Following code simulates a visa approval for an applicant at an embassy. No change to the
//code in class Applicant is allowed.In class Embassy also, no change is allowed other than filling in blank.
//You need to implement callback or pub/sub mechanism in the class VisaProcessor such that class
//Embassy can utilize it. In the VisaProcessor class that you author, you can assume that it approves the
//visa for every applicant when its ProcessVisa method is called – and it informs the registered entities
//about the status in this call itself via calling the callback function set by the entity (Embassy here).
//Complete the code so that when it is run, the output is exactly the following:
//Applicant ID: 1, Status: Approved
//Applicant ID: 2, Status: Approved

using System;
using System.Collections.Generic;
using System.Text;
namespace InSem2Practice
{
    class Embassy
    {
        public static void Main(string[] args)
        {
            List<Applicant> applicants = new List<Applicant>()
            { 
                new Applicant(1), 
                new Applicant(2)
            };
            VisaProcessor visaProcessor = new VisaProcessor();
            visaProcessor.SetCallbackForVisaStatus(() => { 
                //providing callback function
            });
            foreach (var applicant in applicants)
                visaProcessor.ProcessVisa(applicant);
        }
    }
    class Applicant
    {
        public Applicant(int ID) 
        { 
            this.ID = ID; 
        }
        public int ID { get; }
    }
    internal delegate void callBack(); //delegate is used for implementing callback
    class VisaProcessor
    {
        internal void SetCallbackForVisaStatus(callBack cbObj) //function pointer is being passed
        {
            cbObj();
        }
        internal void ProcessVisa(Applicant applicant)
        {
            Console.WriteLine("Applicant Id: {0}, Status: {1}", applicant.ID, "Approved");
        }
    }
}
*/