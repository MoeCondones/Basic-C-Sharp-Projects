using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    public class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<T> Things { get; set; }
        public override void sayName()
        {
            Console.WriteLine("My name is " + firstName + " " + lasName);
        }
        public void Quit()
        {
            Console.WriteLine($" {firstName} {lasName} is quitting the job");
        }
        public void ListThings()
        {
            Console.WriteLine("My info is: ");
            foreach (T thing in Things)
            {
                Console.WriteLine(thing);
            }
        }
        //public static bool operator ==(Employee emp, Employee emp1)
        //{
        //    return emp.id == emp1.id; 
        //}
        //public static bool operator !=(Employee emp, Employee emp1)
        //{
        //    return !(emp == emp1);
        //}
    }
}
