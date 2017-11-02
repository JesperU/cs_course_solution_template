// Decompiled with JetBrains decompiler
// Type: Variabler.Program
// Assembly: Variabler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 02DF8460-F6F9-411F-A647-0928555CAF48
// Assembly location: C:\Users\admin\source\repos\cs_course_solution_template\Variabler\bin\Debug\Variabler.exe

using System;

namespace Variabler
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine(12.5 * 2.0);
      Console.WriteLine((object) FilTyper.csv);
      Console.WriteLine(DateTime.Now.ToString("dMy"));
      Person person;
      person.id = 1;
      person.Navn = "Mikkel";
      Console.WriteLine(person.Navn);
      Console.ReadKey();
    }
  }
}
