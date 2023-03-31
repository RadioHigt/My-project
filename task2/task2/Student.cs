using System;
using System.Collections.Generic;
public class Student
{ 
    public string Surname;
    public DateTime Data;
    public int Number;
    public int[] N=new int[5];
    public void Print()
    {
        Console.WriteLine("Фамилия-"+Surname);
        Console.WriteLine("Дата рождения-"+Data);
        Console.WriteLine("Номер группы-"+Number);
        Console.WriteLine("Успеваемость-");
        for(int i=0;i<5;i++)
        {
            Console.Write(", "+N[i]);
        }
     }
     public void Change()
     {
        string Name=Console.ReadLine();
        Surname=$"{Name}";
        DateTime data1=DateTime.Parse(Console.ReadLine());
        Data=data1;
        int Number1=int.Parse(Console.ReadLine());
        Number=Number1;
      } 
}
