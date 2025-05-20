using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // TestLoad();
            TestLoadL();
        }
        private static void TestLoadL()
        {
            string path = "C:\\Users\\thavishala.c\\Desktop\\C#\\20-05-2025\\" +
                "OrderManagement\\OrderManagement\\bin\\Debug\\OrderManagement.dll";
            Assembly assembly = Assembly.LoadFrom(path);
            Type[] types=assembly.GetTypes();
            Console.WriteLine("types in assembly:");
            foreach (Type t in types)
            {
                Console.WriteLine(t.FullName);  
            }
            Type userType = assembly.GetType("OrderManagement.User");
            var Att = userType.GetCustomAttributes();
            Console.WriteLine("Custom Attributes:");
            foreach (var att in Att)
            {
                //Console.WriteLine(att.ToString());  
                var curtt = (CustomAttributes.DebugInfoAttr)att;
                if(curtt != null)
                {
                    Console.WriteLine("bud details");
                    Console.WriteLine($"Line number:{curtt.LineNumber}-Info:{curtt.BugInfo}");
                }
                Console.WriteLine(att.ToString());
            }
            object UserObject=Activator.CreateInstance(userType,new object[]
            {
                23,"charpitha","char@gmail.com"
            });   
            if(UserObject != null)
            {
                Console.WriteLine("Able to creat Object");
                MethodInfo method= userType.GetMethod("GetUserInfo");
                if(method != null)
                {
                    Console.WriteLine("Able to get reference to method");
                    object methodr = method.Invoke(UserObject,null);
                    Console.WriteLine(methodr);
                }
                MethodInfo method1 = userType.GetMethod("GetUserCount",
                    BindingFlags.Static|BindingFlags.Public);
                if(method1 != null)
                {
                    Console.WriteLine("Able to get user count");
                    object m= method1.Invoke
                        (UserObject,BindingFlags.Static,null,null,null);
                    Console.WriteLine("No of users:"+m);
                }
            }
        }
        public static  void TestLoad()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types= assembly.GetTypes();
           foreach (Type t in types)
            {
                if (t.IsClass)
                {
                    Console.WriteLine($"------{t.Name} is a class----");
                    PropertyInfo[] p = t.GetProperties();
                    Console.WriteLine("------Property List------");
                    foreach(PropertyInfo pi in p)
                    {
                        Console.WriteLine($"Property:{pi.Name}");
                    }
                    ConstructorInfo[] c = t.GetConstructors();
                    Console.WriteLine("-------Constructor Info:--------");
                    foreach (ConstructorInfo ci in c)
                    {
                        ParameterInfo[] pinfo= ci.GetParameters();
                        Console.WriteLine("-------Parameter List--------");
                        foreach (ParameterInfo pi in pinfo)
                        {
                            Console.WriteLine($"{pi.Name}-{pi.ParameterType}");
                        }
                    }
                    MethodInfo[] m = t.GetMethods();
                    Console.WriteLine("-----Method Information:--------");
                    foreach(MethodInfo mi in m)
                    {
                        Console.WriteLine($"{mi.Name}-{mi.IsPublic}");
                    }
                }
                else if(t.IsInterface){
                    Console.WriteLine($"{t.Name} is a interface");
                }
            }
        }
        private static void TestInfo()
        {
            Employee emp = new Employee(10, "ram");
            Type etype = emp.GetType();
            Console.WriteLine("Object Type:" + etype.Name);
            Console.WriteLine("class type:" + etype.IsClass);
            Console.WriteLine("Property Info:");
            PropertyInfo[] prop = etype.GetProperties();
            foreach (PropertyInfo pi in prop)
            {
                Console.WriteLine($"{pi.Name}-{pi.CanWrite}");
            }
        } 
    }
}
