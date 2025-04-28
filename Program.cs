using tabuleiro;
using xadrez;
using xadrez_console;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    
    while(!partida.Terminada)
    {
        try 
        {
            Console.Clear();
            Tela.ImprimirTabuleiro(partida.tab);
            System.Console.WriteLine();
            System.Console.WriteLine("Turno: " + partida.Turno);
            System.Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);

            System.Console.WriteLine();
            System.Console.Write("Origem: ");
            Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeOrigem(origem);
            bool[,] posicoesPossiveis = partida.tab.Peca(origem).MovimentosPossiveis();
            Console.Clear();
            Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

            System.Console.Write("Destino: ");
            Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeDestino(origem, destino);
            partida.RealizaJogada(origem, destino);
        }
        catch (TabuleiroException e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.ReadLine();
        }
    }

}
catch (TabuleiroException e)
{
    System.Console.WriteLine(e.Message);
}