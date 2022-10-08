using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            string result = "";
            int i=0;
            string years = year.ToString();
            string firstHalf = years.Substring(0, years.Length /2);
            string secondHalf = years.Substring(years.Length / 2);
            int fhalf = Int32.Parse(firstHalf);
            if (years.Length < 4)
            {
                i = 0;
            }else
            {
                i = 1;
            }


            if ( secondHalf == "00") {
                result = firstHalf; 
            }else
            {
                int n = fhalf + 1;
                result = n.ToString();
            }


            if (Int32.Parse(result) >= 4 && Int32.Parse(result) <=20)
            {
                return result + "th century";
            } else if ( year <= 100)
            {
                return "1st century"; 
            }

            switch (result[i])
            {
                case '0':
                    return result + "th century";
                case '1':
                    return result + "st century";
                case '2':
                    return result + "nd century";
                case '3':
                    return result + "rd century";
                default:
                    return result + "th century";

            }
        }
    }
}
