using System;
using System.Collections.Generic;
public class Worker
{
    //task1
//     public string name;
//     public string surname;
//     public int rate;
//     public int days;
//     public int GetSalary()
//     {
//         get
//         {
//             return rate * days;
//         }
//     }
//task2
    private string name="Том";
    private string surname="Соер";
    private int rate=0;
    private int days=0;
    public string Name
    {
        get
        {
            return name;
        }
    }
    public string Surname
    {
        get
        {
            return surname;
        }
    }
    public int Rate
    {
        get
        {
            return rate;
        }
    }
    public int Days
    {
        get
        {
            return days;
        }
    }
    public int GetSalary()
    {
        int a = days * rate;
        return a;
    }
}