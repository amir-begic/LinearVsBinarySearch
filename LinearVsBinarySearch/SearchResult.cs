using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LinearVsBinarySearch
{
    public class SearchResult
    {
        public bool Success;
        public Stopwatch Time;
        public string Successmessage = "";

        public SearchResult(bool success, Stopwatch time)
        {
            Success = success;
            Time = time;
            if (Success == true)
            {
                Successmessage = "succesful";
            }
            else
            {
                Successmessage = "unsuccesful";
            }
        }

        public override string ToString()
        {
            return "The Search was " + Successmessage + " and took " + Time.ElapsedTicks + " ticks.";
        }
    }
}
