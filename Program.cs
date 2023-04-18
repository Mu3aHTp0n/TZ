using System;
using System.Reflection;

namespace TimeZone
{
    internal class Program
    {
        static void Main()
        {
            Type t = typeof(System.TimeZone);

            Console.WriteLine("Методы:");
            foreach (MethodInfo method in t.GetMethods())
            {
                Console.WriteLine($"Nsme: {method.Name}");
                Console.WriteLine($"IsAbstract: {method.IsAbstract}");
                Console.WriteLine($"IsFamily: {method.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {method.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {method.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {method.IsAssembly}");
                Console.WriteLine($"IsPrivate: {method.IsPrivate}");
                Console.WriteLine($"IsPublic: {method.IsPublic}");
                Console.WriteLine($"IsConstructor: {method.IsConstructor}");
                Console.WriteLine($"IsStatic: {method.IsStatic}");
                Console.WriteLine($"IsVirtual: {method.IsVirtual}");
                Console.WriteLine($"ReturnType: {method.ReturnType}");
                Console.WriteLine();
            }

            Console.WriteLine("Конструкторы:");
            foreach (ConstructorInfo constructor in t.GetConstructors())
            {
                Console.WriteLine($"Name: {constructor.Name}");
                Console.WriteLine($"IsFamily: {constructor.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {constructor.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {constructor.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {constructor.IsAssembly}");
                Console.WriteLine($"IsPrivate: {constructor.IsPrivate}");
                Console.WriteLine($"IsPublic: {constructor.IsPublic}");
                Console.WriteLine();
            }

            Console.WriteLine("Поля:");
            foreach (FieldInfo field in t.GetFields())
            {
                Console.WriteLine($"Name: {field.Name}");
                Console.WriteLine($"IsFamily: {field.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {field.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {field.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAsembly: {field.IsAssembly}");
                Console.WriteLine($"IsPrivate: {field.IsPrivate}");
                Console.WriteLine($"IsPublic: {field.IsPublic}");
                Console.WriteLine($"IsStatic: {field.IsStatic}");
                Console.WriteLine();
            }

            Console.WriteLine("Свойства:");
            foreach (PropertyInfo Properties in t.GetProperties())
            {
                Console.WriteLine($"Attributes: {Properties.Attributes}");
                Console.WriteLine($"CanRead: {Properties.CanRead}");
                Console.WriteLine($"CanWrite: {Properties.CanWrite}");
                Console.WriteLine($"GetMethod: {Properties.GetMethod}");
                Console.WriteLine($"SetMethod: {Properties.SetMethod}");
                Console.WriteLine($"ProprtyType: {Properties.PropertyType}");
                Console.WriteLine();
            }    
        }
    }
}
