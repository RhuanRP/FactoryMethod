public abstract class TelaMensagem
{
  public abstract IBotao Criarbotao();
  public abstract ICampoTexto CriarCampoTexto();
  public void Mostrar()
  {
    var botao = Criarbotao();
    Console.WriteLine(botao.Mostrar());
    var campoTexto = CriarCampoTexto();
    Console.WriteLine(campoTexto.Mostrar());
  }
}