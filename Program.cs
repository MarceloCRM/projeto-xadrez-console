using tabuleiro;
using xadrez;
using xadrez_console;

try
{    
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

    Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException e)
{
    System.Console.WriteLine(e.Message);
}