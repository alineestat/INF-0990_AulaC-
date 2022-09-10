namespace ProjetoFinal;



class Mapa
{
    public void draw()
    {

        string[,] array2D  = new string[10,10]  { { "ME", "--", "--", "--", "--", "--", "--", "--", "--", "--"}, { "--", "--", "--", "--", "$$", "--", "--", "--", "--", "JR"},
                                                { "--", "JB", "--", "--", "--", "$$", "--", "--", "--", "--"}, { "--", "--", "--", "--", "--", "--", "--", "--", "--", "$$"},
                                                { "--", "--", "--", "--", "--", "--", "--", "--", "--", "--"},{ "##", "##", "##", "##", "##", "##", "##", "--", "--", "$$"},
                                                { "--", "--", "--", "--", "--", "--", "--", "--", "--", "--"}, { "--", "--", "--", "--", "--", "--", "JG", "--", "--", "--"},
                                                { "--", "--", "--", "$$", "--", "--", "--", "--", "JR", "--"}, { "--", "JG", "--", "--", "JB", "--", "--", "--", "--", "--"} };

        //System.Console.WriteLine(array2D[0, 1]);
        //System.Console.WriteLine(array2D[0, 1]);
        //System.Console.WriteLine(array2D[1, 0]);
        //System.Console.WriteLine(array2D[1, 1]);

        for (int i = 0; i < array2D.GetLength(0); i++){                       //GetLength especificar a dimensão da matriz
          for (int j = 0; j < array2D.GetLength(1); j++)
                Console.Write(array2D[i, j] + " ");
            Console.Write("\n");
        }
    }   
}

