using System;
namespace CovidHelper
{
    public class Helper
    {
        // variables for helper class

        public string choice = "";
        private string name;
        private decimal temperature;
        private string symptoms;
        private string exposure;
        public string Name
        {
            get { return name; }
            set { name = value; }


        }
        public decimal Temperature
        {
            get { return temperature; }
            set {
                    temperature = value;
            }
        }
        public string Symptoms
        {
            get { return symptoms; }
            set { symptoms = value; }
        }
        public string Exposure
        {
            get { return exposure; }
            set { exposure = value; }
        }

        // function that converts c to f 

        public string CToF(decimal temp, string choice)
        {
            decimal fahrenheit = 0m;
            decimal celsius = 0m;
            string W = "";
            ;

            // conditional to check whether user is using c or f

            if(choice == "C" || choice == "c")
            {
                // function to convert c to f
                fahrenheit = (temp * 9) / 5 + 32;
                W = $"Your temperature is: " + fahrenheit + " " + "F.";
                return W;
            }
            else
            {
                // function to convert f to c
                celsius = (temp - 32) * 5 / 9;
                W = $"Your temperature is: " + celsius + " " +  "C.";
                return W;
            }
        }


    }
}

