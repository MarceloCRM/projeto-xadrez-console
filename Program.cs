using tabuleiro;
using xadrez;
using xadrez_console;

try
{
    Tabuleiro tab = new Tabuleiro(8, 8);
    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(4, 7));
    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(3, 4));
    tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 1));
    Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException e)
{
    System.Console.WriteLine(e.Message);
}