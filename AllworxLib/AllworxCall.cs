using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllworxLib
{
    public class AllworxCall
    {
        // Field 
        private string call;
        private string cDate;
        private string cTime;
        private string cType;
        private string cTo;
        private string cFrom;
        private string cMinutes;
        private string cRate;
        private string cAmount;
        private string cAccCode;


        // Constructor that takes one argument. 
        public AllworxCall(string c)
        {
            call = c;
            breakdownRawCall(c);
        }

        // Method 
        public void SetCall(string newCall)
        {
            call = newCall;
        }

        // Method 
        public string GetCall()
        {
            return call;
        }

        public string GetDate()
        {
            return cDate;
        }

        public string GetTime()
        {
            return cTime;
        }

        public string GetType()
        {
            return cType;
        }

        public string GetTo()
        {
            return cTo;
        }

        public string GetFrom()
        {
            return cFrom;
        }

        public string GetMinutes()
        {
            return cMinutes;
        }

        public string GetRate()
        {
            return cRate;
        }

        public string GetAmount()
        {
            return cAmount;
        }

        public string GetAccCode()
        {
            return cAccCode;
        }

        private void breakdownRawCall(string rc)
        {
            String[] callArray;
            callArray = rc.Split(',');
            cDate = callArray[0];
            cTime = callArray[1];
            cType = callArray[2];
            cTo = callArray[3];
            cFrom = callArray[4];
            cMinutes = callArray[5];
            cRate = callArray[6];
            cAmount = callArray[7];
            cAccCode = callArray[8];

        }
    }
}
