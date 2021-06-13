using System;
using Starting_with_Enums.Components;

namespace Starting_with_Enums.Components
{
    class FindTime
    {
        private DateTime localDateOriginal;
        private string localDateString;

        private string dateTime;
        private string clockTime;

        private int day;
        private int month;
        private int year;

        private Month monthInWords;

        public FindTime()
        {
            this.FindCurrentDate();
        }

        /// <summary>
        /// A method to return to the user information
        /// on what is the current date is and time.
        /// 
        /// This method essentially handles most of the
        /// operations that go behind the scenes.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentDate()
        {
            // Make sure we find the current date at the most updated time frame
            this.FindCurrentDate();

            // Now we just need to return it to the user in a fashion that might seem human like
            string currentDate = this.monthInWords + " " + this.day.ToString() + ", " + this.year.ToString() + ". Current time: " + this.clockTime;
            return currentDate;
        }

        /// <summary>
        /// Find the current Date value and save it with the object
        /// that is used to work with the dates generated.
        /// </summary>
        private void FindCurrentDate()
        {
            localDateOriginal = DateTime.Now;
            localDateString = this.localDateOriginal.ToString();
            this.ParseDate();
            this.EnumDates();
        }

        /// <summary>
        /// Parse the current Date and save all the needed components
        /// with the object that is used to work with the date informaiton.
        /// </summary>
        private void ParseDate()
        {
            // Split the date and find the first part which is the Calendar type date values
            // And the second part which represents the current time, that come one after
            // Another sequentially and are seperated with a space character.
            String[] times = this.localDateString.Split(" ");
            this.dateTime = times[0];
            this.clockTime = times[1];

            // Seperate the Calendar type data into components which represent the current day's
            // Day, Month, Year in the given sequence. The values are also Int16 wise Parsed, to
            // Get values out of them that can be looked up in the Enum Months component.
            times = this.dateTime.Split("/");
            this.day = short.Parse(times[0]);
            this.month = short.Parse(times[1]);
            this.year = short.Parse(times[2]);
        }

        /// <summary>
        /// Using information on Months we know, rename the
        /// information in they style we would want to see 
        /// for months, as humans. Not that anyone is not
        /// a human here. Right?
        /// </summary>
        private void EnumDates()
        {
            this.monthInWords = (Month)this.month;
        }
    }
}
