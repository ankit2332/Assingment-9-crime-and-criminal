using System;
using System.Collections.Generic;
using System.Text;

namespace Assingment_9_crime_and_criminal
{
    class criminal
    {
        private string name;
        private int age;
        private crime[] crimescomitted;

        public criminal(string name, int age)
        {
            this.name = name;
            this.age = age;
            crimescomitted = new crime[10];
        }

        public string getname()
        {
            return name;
        }

        public int getage()
        {
            return age;
        }

        public bool addcrime(crime crimetoadd)
        {
            int crimelength = countcrimes();
            if (crimelength < crimescomitted.Length)
            {
                crimescomitted[crimelength] = crimetoadd;
                return true;
            }
        }

        public int countcrimes()
        {
            
            for(int i = 0; i < crimescomitted.Length; i++)
            {
                if (crimescomitted[i] != null) return i;
            }
            return crimescomitted.Length;
        }

        public crime getcrime(int i)
        {
            if(i <= countcrimes())
            {
                return crimescomitted[i];
            }
            else
            {
                return null;
            }
        }
       
    }
}
