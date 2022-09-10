namespace ProjetoFinal;

public class ProgramaPrincipal
{
    public ProgramaPrincipal(){
        Mapa m = new Mapa();
        m.InsertdEnd(2,5,"##");
        m.InsertdEnd(1,1,"ME");
        m.draw(); 


    }
    public static void Main(){

        ProgramaPrincipal p = new ProgramaPrincipal();                    /// p nome do programa
    }
}
