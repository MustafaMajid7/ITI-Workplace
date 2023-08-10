using System.Text;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e1 = new employee(1, securityPrivelage.Guest ^ securityPrivelage.Developer ^
                securityPrivelage.Secretary^ securityPrivelage.DBA, 30000m,
                new hiringDate(), Gender.Male);

            employee e2 = new employee(2, securityPrivelage.DBA, 15000m,
                new hiringDate(23,6,2020), Gender.Male);

            employee e3 = new employee(3, securityPrivelage.Guest, 3000m,
                new hiringDate(5,1,1980), Gender.Feamle);


            employee[] arr_emp = new employee[] { e1, e2, e3 };


            foreach (var item in arr_emp)
            {
                Console.WriteLine(item);
            }

            Array.Sort(arr_emp);

            foreach (var item in arr_emp)
            {
                Console.WriteLine(item);
            }

            try { 
            employee e4 = new employee(int.Parse(Console.ReadLine()), securityPrivelage.Guest, 3000m,
                new hiringDate(5, 1, 1980), Gender.Feamle);
            }

            catch (Exception ex)
            {
                FileStream fs = File.Open(@"E:\ITI\workplace\advanced c#\Day4\log.txt", FileMode.Append);

                Byte[] mylog = new UTF8Encoding().GetBytes(ex.Message + "\n");


                fs.Write(mylog);

                fs.Close();
            }
        }
    }
}