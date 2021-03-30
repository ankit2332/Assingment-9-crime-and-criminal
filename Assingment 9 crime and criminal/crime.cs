using System;
using System.Collections.Generic;
using System.Text;

namespace Assingment_9_crime_and_criminal
{
    class crime
    {
        private DateTime Date;
        private string location;
        private string act;

        public crime(DateTime Date, string location, string act)
        {
            Date = Date;
            location = location;
            act = act;
        }

        public string getlocation()
        {
            return location;
        }
    }
}
