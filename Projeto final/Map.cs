

public class Map
{

    public Cell[,] mapa;
    public int rowLength;
    public int colLength;
    public Map(int altura, int largura = 0){
        if (largura == 0){
            rowLength = altura;
            colLength = altura;
        }
        else{
            rowLength = altura;
            colLength = largura;
        }
        mapa = new Cell[rowLength,colLength];
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++) 
            {
                mapa[i,j] = new Empty(j,i); 
            }
        }
    }
    public void AddElement(string element , int x, int y){
        switch(element){
            case "JR":
                mapa[y,x] = new Jewel(JewelType.Red, x, y);
            break;
            case "JB":
                mapa[y,x] = new Jewel(JewelType.Blue, x, y);
            break;
            case "JG":
                mapa[y,x] = new Jewel(JewelType.Green, x, y);
            break;
            case "$$":
                mapa[y,x] = new Obstacle(ObstacleType.Tree, x ,y);
            break;
            case "##":
                mapa[y,x] = new Obstacle(ObstacleType.Water, x, y);
            break;
        }
    }

    public void RemoveElement(int x, int y){
        mapa[y,x] = new Empty(x,y);
    }

    public void Draw(Robot player){
        string[,] temporario = new string[rowLength, colLength];
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++) 
            {
                switch (mapa[i,j].ToString()){
                    case "--":
                        Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                    case "JB":
                        Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                    case "JG":
                        Console.ForegroundColor = ConsoleColor.Green;
                    break;
                    case "JR":
                        Console.ForegroundColor = ConsoleColor.Red;
                    break;
                    case "$$":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                    case "##":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                }
                if ((j,i) == (player.X,player.Y)){
                    Console.Write(string.Format("{0} ", player.ToString()));
                }
                else{
                    Console.Write(string.Format("{0} ", mapa[i, j].ToString()));
                }
;            }
            Console.Write("\n");
        }    
    } 
}




