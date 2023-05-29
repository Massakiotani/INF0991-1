using System.Reflection.PortableExecutable;

public class Robot : Cell
{
    public int X {get; set;}
    public int Y {get; set;}
    public List<int> sacola = new List<int>();
    public Map mapa; 
    public Robot(int x, int y, Map mapa_inicial){
        X = x;
        Y = y;
        mapa = mapa_inicial;
    }
    public void Move(string direction){
        switch (direction){
            case "South":
                if (mapa.mapa[Y+1, X] is not Obstacle){
                    Y += 1;
                }
            break;
            case "North":
                if (mapa.mapa[Y-1, X] is not Obstacle){
                    Y -= 1;
                }
            break;
            case "East":
                if (mapa.mapa[Y, X+1] is not Obstacle){
                    X += 1;
                }
            break;
            case "West":
                if (mapa.mapa[Y, X-1] is not Obstacle){
                    X -= 1;
                }
            break;
        }
    }
        public override string ToString()
    {
        return "ME";
    }
    public void Pick(){
        if (mapa.mapa[Y,X] is Jewel){
            sacola.Add((int)(((Jewel)mapa.mapa[Y,X]).type));
            mapa.RemoveElement(X,Y);
        }
    }
    
    public void JewelQuantity(){
        Console.WriteLine("Quantidade de joias: {0}", sacola.Count);
    }

    public void JewelTotalValue(){
        Console.WriteLine("Valor total das joias: {0}", sacola.Sum());
    }

}
