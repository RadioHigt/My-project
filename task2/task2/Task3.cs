using System;
using System.Collections.Generic;
public class Twonumbers
{ 
    public int A; 
    public int B; 
    public int Sum() 
    { 
        return A+B; 
    } 
    public void Print() 
    { 
        Console.WriteLine(A); 
        Console.WriteLine(B); 
    } 
    public void Change() 
    { 
        A=int.Parse(Console.ReadLine()); 
        B=int.Parse(Console.ReadLine()); 
    } 
    public int More() 
    { 
        if(A>B) 
        {
            return A; 
        }
        else 
        { 
            return B; 
        }
        
    }
}