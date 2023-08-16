using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class SocialAssurance
    {
        //public int amount { get; set; }

        public static void AssuranceEnrolled(object obj,EventArgs e)
        {
            Employee emp = obj as Employee;
            Console.WriteLine(emp.ToString() + " Got assured");
        }

        //public static void GotAssured(object obj, EventArgs e)
        //{
        //    Employee emp = obj as Employee;
        //    Console.WriteLine($"{emp.name} got subscribed in social");
        //}
        //public static void Deleted(object obj, EventArgs e)
        //{
        //    Employee emp = obj as Employee;
        //    Console.WriteLine($"{emp.name} got subscribed");
        //}
    }
}
