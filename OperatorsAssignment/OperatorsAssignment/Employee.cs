using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int Id {get; set;}
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Overload "==" Operator, comparing two Employee objects by Id property //
        public static bool operator ==(Employee emp1, Employee emp2)
        {

            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return ReferenceEquals(emp1, emp2);

            return emp1.Id == emp2.Id;

        }

        // Override Equals and GetHashCode for consistency //
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
        public override bool Equals(object obj)
        {
 
                
                if (obj is Employee other)
                   
                    return this.Id == other.Id;

            return false;
            
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
