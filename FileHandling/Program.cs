using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHandling.Models;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                
                const string FILENAME = "..\\..\\employee.txt";
                const char DELIM = ',';

                // opening filestream
                FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);

                // setup variables to temporariliy hold my data
                string recordString;
                string[] fields;

                // read from file and assign the record to recordIN
                recordString = reader.ReadLine();

                while(recordString != null)
                {
                    Employee employee = new Employee();
                    fields = recordString.Split(DELIM);
                    employee.EmployeeID = Convert.ToInt32(fields[0]);
                    employee.FirstName = fields[1];
                    employee.LastName = fields[2];
                    employee.Salary = Convert.ToDouble(fields[3]);
                    employees.Add(employee);

                    Console.WriteLine("{0} {1} {2} {3}",
                        employee.EmployeeID, 
                        employee.FirstName, 
                        employee.LastName,
                        employee.Salary.ToString("C"));

                    recordString = reader.ReadLine();
                }

                // close streams
                reader.Close();
                inFile.Close();
            }
            catch (Exception exception)
            {

                Console.WriteLine("Error: " + exception.Message);
            }
            
        }
    }
}
