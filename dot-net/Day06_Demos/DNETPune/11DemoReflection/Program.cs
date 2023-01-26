#region Version 3: Reflection
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace _11DemoReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathOfAssembly = @"C:\Users\mahes\OneDrive\Desktop\DNETPune\DNETPune\Arithmatic\bin\Debug\Arithmatic.dll";

            Assembly assembly = Assembly.LoadFrom(pathOfAssembly);

            Type[] allTypes = assembly.GetTypes();

            object dynamicObejct = null;

            foreach (Type type in allTypes)
            {
                Console.WriteLine("-----------------------------------");
                
                Console.WriteLine("Creating object of Type : " +
                                                    type.FullName);

                dynamicObejct = assembly.CreateInstance(type.FullName);
               
                Console.WriteLine("-----------------------------------");

                MethodInfo[] allMethods = type.GetMethods();

                foreach (MethodInfo method in allMethods)
                {
                    Console.WriteLine("Calling Method : " + method.Name);

                    ParameterInfo[] allParams = method.GetParameters();

                    object[] allParameterValues =
                                new object[allParams.Length];

                   for(int i = 0; i < allParams.Length; i ++)
                    {
                        ParameterInfo parameter = allParams[i];
                        Console.WriteLine("Enter value for {0} of type {1}", parameter.Name, parameter.ParameterType);

                        allParameterValues[i] = 
                            Convert.ChangeType(Console.ReadLine(),
                                               parameter.ParameterType);

                    }



                   object result =  type.InvokeMember(method.Name,
                                        BindingFlags.Public |
                                        BindingFlags.Instance |
                                        BindingFlags.InvokeMethod,
                                        null, dynamicObejct,
                                        allParameterValues);

                    Console.WriteLine( result );

                }

            }

        }
    }
}
#endregion

#region Version 2: Reflection
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Reflection;

//namespace _11DemoReflection
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string pathOfAssembly = @"C:\Users\mahes\OneDrive\Desktop\DNETPune\DNETPune\Arithmatic\bin\Debug\Arithmatic.dll";

//            Assembly assembly = Assembly.LoadFrom(pathOfAssembly);

//            Type[] allTypes = assembly.GetTypes();

//            foreach (Type type in allTypes)
//            {
//                Console.WriteLine("-----------------------------------");
//                Console.WriteLine(type.FullName);

//                IEnumerable<Attribute> allAttributesOnType =
//                                        type.GetCustomAttributes();

//                bool isTypeSerializable = false;
//                foreach (Attribute attribute in allAttributesOnType)
//                {
//                    if (attribute is SerializableAttribute)
//                    {
//                        isTypeSerializable = true;
//                        break;
//                    }
//                }
//                if (isTypeSerializable)
//                {
//                    Console.WriteLine(type.Name + " is marked as Serializable!");
//                }
//                else
//                {
//                    Console.WriteLine(type.Name + " is NOT marked as Serializable!");
//                }
//                Console.WriteLine("-----------------------------------");

//                MethodInfo[] allMethods = type.GetMethods();
//                foreach (MethodInfo method in allMethods)
//                {
//                    string details = "";
//                    details = details + method.ReturnType + " " + method.Name + "( ";

//                    ParameterInfo[] allParams = method.GetParameters();
//                    foreach (ParameterInfo parameter in allParams)
//                    {
//                        details = details + parameter.ParameterType.ToString()
//                                    + " " + parameter.Name + ",";
//                    }

//                    details = details.TrimEnd(',');
//                    details = details + ")";
//                    Console.WriteLine(details);
//                    Console.WriteLine("-----------------------------------");

//                }

//            }

//        }
//    }
//}
#endregion

#region Version 1: Reflection
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Reflection;

//namespace _11DemoReflection
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // string pathOfAssembly = @"C:\Users\mahes\OneDrive\Desktop\DNETPune\DNETPune\Arithmatic\bin\Debug\Arithmatic.dll";

//            Console.WriteLine("Enter the path of Assembly:");
//            string pathOfAssembly = Console.ReadLine();

//           Assembly assembly = Assembly.LoadFrom(pathOfAssembly);

//            Type[] allTypes = assembly.GetTypes();

//            foreach (Type type in allTypes)
//            {
//                Console.WriteLine(type.FullName);

//                MethodInfo[] allMethods = type.GetMethods();


//                foreach (MethodInfo method in allMethods)
//                {
//                    string details = "";
//                    details = details + method.ReturnType + " " + method.Name + "( ";

//                    ParameterInfo []allParams = method.GetParameters();
//                    foreach (ParameterInfo parameter in allParams)
//                    {
//                    details = details +  parameter.ParameterType.ToString()
//                                + " " + parameter.Name + ",";
//                    }

//                    details = details.TrimEnd(',');
//                    details = details +")";
//                    Console.WriteLine(details);
//                }

//            }

//        }
//    }
//}
#endregion
