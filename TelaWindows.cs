public class TelaWindows : TelaMensagem
{
  public override IBotao Criarbotao()
  {
    return new BotaoWindows();
  }

  public override ICampoTexto CriarCampoTexto()
  {
    return new CampoTextoWindows();
  }
}