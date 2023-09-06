namespace LINQ
{
    internal class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Code}. {Name}";
        }

    }
    internal class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Subject[] Subjects;
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1

            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };


            //foreach (var item in numbers.Distinct().OrderBy(x => x))
            //    Console.WriteLine(item);

            //foreach (var item in numbers.Distinct().
            //    Select(x=> new {Number = x,Multiply = Math.Pow(x,2)}).OrderBy(x => x.Number))
            //    Console.WriteLine(item);

            #endregion

            #region Task 2

            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            //foreach (var item in names.Where(x=>x.Length ==3))
            //    Console.WriteLine(item);

            //foreach (var item in from n in names
            //                     where n.Length==3
            //                     select n)
            //    Console.WriteLine(item);

            //-------------------------------------------------------------------------------------

            //foreach (var item in names.Where(x => x.ToLower().Contains('a')).OrderBy(x=>x.Length))
            //    Console.WriteLine(item);

            //foreach (var item in from n in names
            //                     where n.ToLower().Contains('a')
            //                     orderby n.Length
            //                     select n)
            //    Console.WriteLine(item);

            //-------------------------------------------------------------------------------------

            //foreach (var item in names.Take(2))
            //    Console.WriteLine(item);

            //foreach (var item in (from n in names
            //                     select n).Take(2))
            //    Console.WriteLine(item);


            #endregion

            #region Task 3

            List<Student> Students = new List<Student>(){

                 new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",
                    Subjects=new Subject[]{
                        new Subject() { Code=22,Name="EF"},
                            new Subject() { Code=33,Name="UML"}
                    }
                 },

                new Student(){ ID=2, FirstName="Mona", LastName="Gala",
                    Subjects=new Subject []{
                        new Subject(){ Code=22,Name="EF"},
                            new Subject (){ Code=34,Name="XML"},
                                new Subject (){ Code=25, Name="JS"}
                    }
                },

                new Student(){ ID=3, FirstName="Yara", LastName="Yousf",
                    Subjects=new Subject []{
                        new Subject (){ Code=22,Name="EF"},
                            new Subject (){ Code=25,Name="JS"}
                    }
                },

                new Student(){ ID=1, FirstName="Ali", LastName="Ali",
                    Subjects=new Subject []{
                        new Subject (){ Code=33,Name="UML"}
                    }
                },

            };

            //foreach (var item in Students.Select(x => new { FullName = x.FirstName+" "+
            //    x.LastName,NoOfSubjects = x.Subjects.Length}))
            //    Console.WriteLine(item);

            //foreach (var item in from s in Students
            //                     select new { FullName = s.FirstName + " " +
            //                                  s.LastName, NoOfSubjects = s.Subjects.Length})
            //    Console.WriteLine(item);

            //-------------------------------------------------------------------------------------

            //foreach (var item in Students.OrderByDescending(x=>x.FirstName).ThenBy(x=>x.LastName).
            //    Select(x => new {FullName = x.FirstName + " "+ x.LastName}))
            //        Console.WriteLine(item);

            //-------------------------------------------------------------------------------------

            //var name = Students.GroupBy(x => new { fullname = $"{x.FirstName} {x.LastName}" });

            //foreach (var item in name)
            //{
            //    Console.WriteLine(item.Key.fullname);
            //    foreach (var item1 in Students.Where(x => $"{x.FirstName} {x.LastName}" == item.Key.fullname)
            //        .SelectMany(x=>x.Subjects))
            //    {
            //        Console.WriteLine("\t"+item1.Name);
            //    }

            //}

            //foreach (var item in Students)
            //{
            //    foreach (var item1 in Students.Where(x => $"{item.FirstName} {item.LastName}" == $"{x.FirstName} {x.LastName}")
            //        .SelectMany(s => s.Subjects))
            //    {
            //        Console.WriteLine(item.FirstName + " " + item.LastName + " Subject Name " + item1.Name);
            //    }
            //}

            //var name1s = Students.SelectMany(s => s.Subjects, (studentName, subjectName)
            //    => new { StudentName = studentName.FirstName + " " + studentName.LastName, SubjectName = subjectName.Name });

            //foreach (var s in name1s)
            //{
            //    Console.WriteLine(s);
            //}

            var name1s = Students.SelectMany(s => s.Subjects, );


            foreach (var s in Students.SelectMany(s => s.Subjects))
            {
                Console.WriteLine(s);
            }

            #endregion

        }
    }
}