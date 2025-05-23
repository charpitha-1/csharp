using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Xml.Serialization;
using System.Text.Json; 
using System.IO;

namespace SerializationDemo
{
    
    internal class Program
    {
        static void Main(string[] args)
        { //Json
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "ram";
            employee.Address = "Door no :1,dhone";
            employee.Password = "123556";
            employee.Phones = new string[] { "2343645", "3467487", "46976434" };
            /*string json = JsonSerializer.Serialize<Employee>(employee, new JsonSerializerOptions()
            {
                //IndentSize = 5
            });*/
            string json = JsonSerializer.Serialize<Employee>(employee, new JsonSerializerOptions());
           Console.WriteLine(json);  
            //StreamWriter xsw= new StreamWriter("Employee.json");
            //xsw.WriteLine(json);
            //xsw.Close();

            //StreamReader xsr = new StreamReader("Employee.json");
            //string json1= xsr.ReadToEnd();
            //Employee empout= JsonSerializer.Deserialize<Employee>(json1);
            //Console.WriteLine(empout.Name);

        }
        private static void Test()
        { //binary
            /* Employee employee = new Employee();
             employee.Id = 1;
             employee.Name = "ram";
             employee.Address = "Door no :1,dhone";
             //Serialization process
            FileStream fs=new FileStream("Employee.bin",FileMode.OpenOrCreate,FileAccess.Write);

             BinaryFormatter bf = new BinaryFormatter();
             bf.Serialize(fs, employee); //serialize the object to stream
             fs.Close();//close the stream*/

            //Deserializable
            /*(FileStream fs = new FileStream("Employee.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter bfn = new BinaryFormatter();
            Employee emp = bfn.Deserialize(fs) as Employee;
            fs.Close();
            Console.WriteLine(emp.Name);*/
        }
        private static void TestXml()
        { //Xml
            /*Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "ram";
            employee.Address = "Door no :1,dhone";
            employee.Password = "123556";
            employee.Phones = new string[] { "2343645", "3467487", "46976434" };
            XmlSerializer xser = new XmlSerializer(typeof(Employee));
            StreamWriter sw = new StreamWriter("Employee.xml");
            xser.Serialize(sw, employee);
            sw.Close();

            //Deserialization
            XmlSerializer xdser = new XmlSerializer(typeof(Employee));
            StreamReader sr = new StreamReader("Employee.xml");
            Employee emp = xdser.Deserialize(sr) as Employee;
            Console.WriteLine(emp.Name);*/
        }
    }
}
