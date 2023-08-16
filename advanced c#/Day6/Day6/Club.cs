using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Club
    {
        public static List<Employee> employees = new List<Employee>();

        public static void ClubEnrolled(object obj, EventArgs e)
        {
            Employee? emp = obj as Employee;

            employees.Add(emp);

            //Console.WriteLine(emp.ToString() + " Got enrolled in our club");
        }
        public static void ClubRemoved(object obj, EventArgs e)
        {
            Employee? emp = obj as Employee;
            if(employees.Remove(emp))
                Console.WriteLine(emp.name + " successfully removed");
            else
                Console.WriteLine(emp.name + " isn't enrolled in club");
            //Console.WriteLine(emp.ToString() + " Got removed from our club");
        }

        
    }
}
