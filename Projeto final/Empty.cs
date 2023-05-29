

public class Empty : Cell
{
    public int X {get; set;}
    public int Y {get; set;}
    public Empty(int x, int y){
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return "--";
    }
}
