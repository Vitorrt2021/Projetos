using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            var teste = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);
            while(campoMinado.JogoStatus == 0)
            {
                Console.Write("Linha: ");
                var linha = Int32.Parse(Console.ReadLine());
                Console.Write("Coluna:  ");
                var coluna = Int32.Parse(Console.ReadLine()) ;
                
                
                char[,] array = new char[10,10];
                int x=0;
                
                for(int i=1;i < 10;i++)
                {
                    for(int j=1;j < 10;j++)
                    {
                        teste.Abrir(i,j);
                        string campoTeste = teste.Tabuleiro.Replace("\n", ""); 
                        campoTeste = campoTeste.Replace("\r", "");
                        array[i,j] = campoTeste[x];    
                        x+=1;
                    }
                }
                
                if(array[linha,coluna] == '*')
                {
                    Console.WriteLine("Essa posição não está livre");
                }
                else
                {
                    Console.WriteLine("Livre para abrir");
                    campoMinado.Abrir(linha , coluna);
                } 
                               
                Console.WriteLine(campoMinado.Tabuleiro);
            }
            if(campoMinado.JogoStatus== 1)
            {
                Console.Write("======================================= \n");
                Console.Write("============ Você Venceu!! ============\n");
                Console.Write("=======================================");
            }
            else
            {
                Console.Write("======================================= \n");
                Console.Write("============= Você Perdeu =============\n");
                Console.Write("=======================================");
            }


            // Realize sua codificação a partir deste ponto, boa sorte!

        }
    }

}


