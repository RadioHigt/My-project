using System;
public class Five
{
    public int A;
    public int B;
    public Five(int value, int meaning)
    {
        A=value;
        B=meaning;
    }
    public Five()
    {
        Random rand=new Random();
        A=rand.Next(1,10);
        B=rand.Next(1,10);
    }
    ~Five()
    {
        Console.WriteLine("Объект удалён");
    }
}