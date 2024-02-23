public class TelaWeb : TelaMensagem
{
  public override IBotao Criarbotao()
  {
    return new BotaoWeb();
  }
  public override ICampoTexto CriarCampoTexto()
  {
    return new CampoTextoWeb();
  }
}