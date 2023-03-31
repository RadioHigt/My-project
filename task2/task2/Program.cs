using System;
using System.Collections.Generic;

class MyClass
{
    static void Main()
    {
        //task1
        // Student tom=new Student();
        // string name=Console.ReadLine();
        // tom.Surname=$"{name}";
        // DateTime birth=DateTime.Parse(Console.ReadLine());
        // tom.Data=birth;
        // int num=int.Parse(Console.ReadLine());
        // tom.Number=num;
        // for(int i=0;i<5;i++)
        // {
        // int a=int.Parse(Console.ReadLine());
        // tom.N[i]=a;
        // }
        // tom.Print();
        // Console.WriteLine("Вы можете изменить свюфамили, имя, номер группы");
        // string c=Console.ReadLine();
        // string b=$"{c}";
        // if(b=="изменить")
        // {
        // tom.Change();
        // tom.Print();
        // }
        //task2
        // Train[] track=new Train[6];
        // for (int i=0; i<6; i++)
        // {
        // string a=Console.ReadLine();
        // track[i].Punct=$"{a}";
        // int b=int.Parse(Console.ReadLine());
        // track[i].Number=b;
        // DateTimet=DateTime.Parse(Console.ReadLine());
        // track[i].Time=t;
        // }
        // int n=int.Parse(Console.ReadLine());
        // for(int i=0; i<6; i++)
        // {
        // if(track[i].Number==n)
        // {
        // track[i].Print();
        // break;
        // }
        // }
        //task3
        // Twonumbers two=new Twonumbers();
        // two.A=int.Parse(Console.ReadLine());
        // two.B=int.Parse(Console.ReadLine());
        // Console.WriteLine($"сумма={twoSum()}");
        //Console.WriteLine($"Наибольшее={two.More()}");
        // two.Change();
        // two.Print();
        //taxsk4
        // counter num=new counter();
        // num.Rand();
        // num.Print();
        // num.Input();
        // num.Pluc();
        // num.Print();
        // num.Minus();
        // num.Print();
        //task5
        Five a=new Five(1,9);
        Console.WriteLine($"{a.A} {a.B}");
        Five b=new Five();
        Console.WriteLine($"{b.A} {b.B}");
    
    }

}

