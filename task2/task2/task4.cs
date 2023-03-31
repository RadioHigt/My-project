public class Counter
{
public int I; 
public void Rand()
{ 
    Random rand=new Random(); 
    I=rand.Next(1,10); 
} 
public void input() 
{ 
    I=int.Parse(Console.ReadLine()); 
} 
public void pluc() 
{ 
    I++; 
} 
public void minus() 
{ 
    I--; 
} 
public void Print() 
{ 
    Console.WriteLine(I); 
}
}