
public class Obstacle : Cell
{
    public int X {get; set;}
    public int Y {get; set;}
    public ObstacleType tipo;
    public Obstacle(ObstacleType type, int x, int y){
        tipo = type;
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        switch(tipo){
            case ObstacleType.Tree:
                return "$$";
            case ObstacleType.Water:
                return "##";
            default:
                return "--";
        }
    }
}
