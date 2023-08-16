
namespace Day6
{
    //internal delegate void Enroll(Employee employee);
    //internal delegate void Remove(Employee employee);
    internal class Employee
    {
        //public event EventHandler Add;
        //public event EventHandler Remove;

        public int id { get; set; }
        public string name { get; set; }

        int age;
        public int Age { 
            get {
                    return age;
                } 
            set { 
                    age = value;
                if (value > 60)
                    remove(this,null);
            }   
        }

        public event EventHandler remove = Club.ClubRemoved;
        public event EventHandler enroll ;
        public Employee(int id ,string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            enroll = Club.ClubEnrolled;
            enroll += SocialAssurance.AssuranceEnrolled;
            enroll(this,null);
        }

        

        //public int Age { get { return age; } 
        //    set {
        //        age = value;
        //        if (value > 60) {

        //            Remove += SocialAssurance.Deleted;
        //            Remove.Invoke(this, null);   

        //        }

        //    } }

        //public Employee(int id,string name, int age)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.age = age;
        //    Add += Club.GotSubscribe;
        //    Add += SocialAssurance.GotAssured;
        //    Add.Invoke(this, null);


        //}

        public override string ToString()
        {
            return $"{id}- {name} - {age}";
        }

    }
}
