namespace DesignPatterns
{
  public class Michelada : IBebida
  {
    private string Cerveza;

    public Michelada(string Cerveza)
    {
      this.Cerveza = Cerveza; //implicito
    }
    public void Preparar()
    {
      Console.WriteLine("preparando michelada... con cerveza: " + Cerveza); //explicito
    }
  }
}
