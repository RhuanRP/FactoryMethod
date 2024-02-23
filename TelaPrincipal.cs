public class TelaPrincipal
{
  public TelaPrincipal(int app)
  {
    TelaMensagem telaMensagem;
    if (app == 0)
      telaMensagem = new TelaWindows();
    else if (app == 1)
      telaMensagem = new TelaWeb();
    else
      telaMensagem = new TelaWindows();

    telaMensagem.Mostrar();
  }
}