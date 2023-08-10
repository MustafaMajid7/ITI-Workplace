using System.Text;

namespace Day4
{
    internal class employee : IComparable<employee>
        
    {

        public int id { get; set; }
        public securityPrivelage securityLevel { get; set; }
        public decimal salary{ get; set; }
        public hiringDate hiredDate { get; set; }
        public Gender gender { get; set; }

        public employee(int id , securityPrivelage securityLevel , decimal salary,
            hiringDate hiredDate , Gender gender)
        {
            
            this.id = id;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.hiredDate = hiredDate;
            this.gender = gender;
            
            
        }

        public override string ToString()
        {
            return $"Employee number {id} is {gender} whose securityLevel is {securityLevel}" +
                $" takes {salary} hired in {hiredDate} ";
        }

        public int CompareTo(object? obj)
        {
            if (obj is employee e)
            { return hiredDate.CompareTo(e.hiredDate); }
            else
            {
                return 0;
            }
        }

        public int CompareTo(employee? other)
        {
            throw new NotImplementedException();
        }

        int IComparable<employee>.CompareTo(employee? other)
        {
            return hiredDate.(other);
        }
    }
}
