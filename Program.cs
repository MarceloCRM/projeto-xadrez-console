using tabuleiro;
using xadrez;
using xadrez_console;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    
    while(!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.tab);

        System.Console.WriteLine();
        System.Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
        System.Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
        partida.ExecutaMovimento(origem, destino);
    }

}
catch (TabuleiroException e)
{
    System.Console.WriteLine(e.Message);
}