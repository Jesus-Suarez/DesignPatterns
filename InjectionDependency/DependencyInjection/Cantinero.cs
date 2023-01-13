namespace DesignPatterns
{
  public class Cantinero
  {
    IBebida bebida;
    public Cantinero(IBebida ibebida)
    {
      bebida = ibebida;
    }

    public void Preparar()
    {
      bebida.Preparar();
    }
  }
}
