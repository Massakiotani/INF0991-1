using System;
using System.Globalization;

public class Jewel : Cell
{
    public static int JewelQuantity = 0;
    public JewelType type; 
    public int X {get; set;}
    public int Y {get; set;} 

    public override string ToString()
    {
        switch(type){
            case JewelType.Blue:
                return "JB";
            case JewelType.Green:
                return "JG";
            case JewelType.Red:
                return "JR";
            default:
                return "--";
        }
    }
    public Jewel(JewelType tipo, int x , int y){
        JewelQuantity += 1; 
        type = tipo;
        X = x;
        Y = y;
    }

}
