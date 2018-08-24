using System;

namespace AgeLibrary
{
    public class DateOfBirth
    {
        int day;
        int month;
        int year;


        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else
                    year = 1900;
            }
        }

        public DateOfBirth()
        {
            Day = 1;
            Month = 1;
            Year = 1900;
        }

        public bool IsValidDate(string date)
        {
            //DateTime temp;
            if (DateTime.TryParse(date, out DateTime temp))
            {
                Day = temp.Day;
                Month = temp.Month;
                Year = temp.Year;
                return true;
            }
            else
                return false;
        }

        public string ShowAge()
        {
            //if (DateTime.Parse($"{this.Day}/{this.Month}/{this.Year}") <= DateTime.Now.Date)
           

            //if (temp <= DateTime.Now.Date)
            //{


                int currentDay = DateTime.Now.Day;
                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;
                int days = 0, months = 0, years = 0;
                int[] daysInMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (DateTime.IsLeapYear(currentYear))
                { daysInMonths[1] = 29; }

                if (this.Day > currentDay)
                {
                    currentMonth = currentMonth - 1;
                    currentDay = daysInMonths[this.Month - 1] + currentDay + 1;
                }

                if (this.Month > currentMonth)
                {
                    currentYear = currentYear - 1;
                    currentMonth = currentMonth + 12;
                }

                days = currentDay - this.Day;
                months = currentMonth - this.Month;
                years = currentYear - this.Year;

                //Console.WriteLine($"\nYears: {years}, Months: {months}, Days: {days}");
                return $"Years: {years}, Months: {months}, Days: {days}";
            //}
            //else
            //{
            //    return "Error";
            //    //Console.WriteLine("The given date is a future date");
            //}
        }
        
    }
}
