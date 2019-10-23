using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Em1 = new Employee();

            Em1.date = "1900-09-01";

            Console.WriteLine();
        }
    }

    public class Employee
    {
        public int PersoneNum { get; set; }
        public string personeName { get; set; }
        public string phonenum { get; set; }
        public string department { get; set; }
        public string address { get; set; }

        public string date { get; set; }

    }
    class EmployeeManager
    {
        List<Employee> list = new List<Employee>();
        public void addEmployee()

        {
            Employee temp = new Employee();

            temp.PersoneNum = int.Parse(Console.ReadLine());
            temp.phonenum = Console.ReadLine();
            temp.department = Console.ReadLine();
            temp.address = Console.ReadLine();
            temp.date = Console.ReadLine();

            list.Add(temp);
        }
        public void deleteEmployee()
        {

        }
        public void changeEmployee(int input)
        {
            input = int.Parse(Console.ReadLine());

            }
            public void searchEmployee()
            {

            }
        }
    }
