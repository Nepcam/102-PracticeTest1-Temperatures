using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_PracticeTest1_Temperatures
{
    class Reading
    {
        private string _date;
        private double _high;
        private double _low;

        // Constructor ################################################################
        /// <summary>
        /// Initialises the object to the values passed in
        /// </summary>
        /// <param name="date">The date of the reading</param>
        /// <param name="high">The high value for that date</param>
        /// <param name="low">The low values for that date</param>
        public Reading(string date, double high, double low)
        {
            Date = date;
            High = high;
            Low = low;
        }

        // Public Properties ##################################################################

        /// <summary>
        /// Gets the date of the reading
        /// </summary>
        public string Date
        {
            get { return _date; }
            set
            {
                // ERROR Checking - if what is in the value does not equal an empty string ""
                if (value != "") // you need to use the value keyword, because you are not in the constructor
                {
                    // add that value to _date
                    _date = value;
                }
                else
                {
                    throw new Exception("The date must be specified");
                }
            }
        }

        /// <summary>
        /// gets and sets the high temp value for that date
        /// </summary>
        public double High
        {
            get { return _high; }
            set { _high = value; }
        }

        /// <summary>
        /// gets and sets the low temp value for that date
        /// </summary>
        public double Low
        {
            get { return _low; }
            set { _low = value; }
        }

        /// <summary>
        /// Gets the average temperature for the date
        /// </summary>
        public double AveTemp
        {
            get { return (High + Low) / 2; }
        }

        /// <summary>
        /// Gets all the information about a reading
        /// </summary>
        /// <returns>All information as a neatly padded out string</returns>
        public override string ToString()
        {
            return Date.PadRight(15) + High.ToString().PadRight(10) + Low.ToString().PadRight(10) + AveTemp;
        }

        /// <summary>
        /// Gets the average temperature
        /// </summary>
        /// <returns>The average temperature</returns>
        public double AverageTemp()
        {
            return (High + Low) / 2;
        }
    }
}
