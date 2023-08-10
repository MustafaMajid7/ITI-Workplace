
namespace Day4
{
    internal class hiringDate : IComparable<hiringDate>
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public hiringDate(int day = 12, int month = 7, int year = 1998)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day} : {Month} : {Year}";
        }

        int IComparable<hiringDate>.CompareTo(hiringDate? other)
        {
            return Year.CompareTo(other.Year);
        }

        //public int CompareTo(object? obj)
        //{
        //    if (obj is hiringDate hd)
        //    { return Year.CompareTo(hd.Year); }
        //    else
        //    {
        //        return 0;
        //    }
        //}
    }
}
