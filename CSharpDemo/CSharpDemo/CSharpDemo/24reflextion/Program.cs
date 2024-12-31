using System.Reflection;

namespace _24reflextion
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string assemblyPath = @"C:\Users\IET\Desktop\67 & 49\.NET\CSharpDemo\CSharpDemo\CSharpDemo\23class\bin\Debug\net6.0\23class.dll";

           Assembly asm = Assembly.LoadFrom(assemblyPath);
           Type[] types = asm.GetTypes();
        
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];
                MethodInfo[] allMethods = type.GetMethods();
                string str = null;
                for (int j = 0; j < allMethods.Length; j++)
                {
                    MethodInfo method = allMethods[j];
                    str = method.ReturnType + " " + method.Name + " ( ";
                    ParameterInfo[] allParameters = method.GetParameters();
                    for (int k = 0; k < allParameters.Length; k++)
                    {
                        ParameterInfo param = allParameters[k];
                        str = str + param.ParameterType.ToString() + " " +
                            param.Name + ",";
                    }
                    str = str.TrimEnd(',') + " )";
                    Console.WriteLine(str);
                }

                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];
                    if (attr is SerializableAttribute)
                    {
                        Console.WriteLine($"Type: {type.Name} class is Serializable");
                    }
                }
            }






        }
    }
}
