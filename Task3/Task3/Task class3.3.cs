using System;
using System.Collections.Generic;
public class Calculation
{
    public string  calculationLine="";
    public string SetCalculationLine
    {
        set 
        {
            calculationLine = value;
        }
    }
    public string SetLastSymbolCalculationLine
    {
        set 
        { 
            calculationLine = calculationLine+value;
        }
    }
    public string GetCalculationLine
    {
        get 
        {
            return calculationLine;
        }
    }
    public char GetLastSymbol
    {
        get 
        {
            return calculationLine[calculationLine.Length-1]; 
        }
    }
    public string  DeleteLastSymbol
    {
        get 
        {
            return calculationLine.Remove(calculationLine.Length-1);
        }
    }
}