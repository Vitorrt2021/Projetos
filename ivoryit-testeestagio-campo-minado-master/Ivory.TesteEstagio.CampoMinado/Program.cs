using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {


        public static int Encontrar(int filledField){
        //Função para encontrar as bombas  o 8 representa - as casas cobertas e o 9 representa a bomba * 
        for(int i = 0; i<tamanho; i++){
            for(int k=0; k<tamanho; k++){
                if(filledField[i,k]!=9){
                    if(i>0){
                        if(k>0){
                            switch(filledField[i-1,k-1])
                            {
                                case 8:
                                contador4 +=1;
                                case 9:
                                contador5 +=1;

                            }
                        }
                    }
                        switch(filledField[i-1,k])
                                {
                                    case 8:
                                    contador4 +=1;
                                    case 9:
                                    contador5 +=1;

                                }
                    if(k+1<tamanho){                            
                        switch(filledField[i-1,k+1])
                                {
                                    case 8:
                                    contador4 +=1;
                                    case 9:
                                    contador5 +=1;
                                }
                    }

                    if(k>0){
                        switch(filledField[i,k-1])
                            {
                                case 8;
                                contador4 +=1;
                                case 9:
                                contador5 +=1;

                            }
                    }
                    if(k+1<tamanho){
                        switch(filledField[i,k+1])
                            {
                                case 8:
                                contador4 +=1;
                                case 9:
                                contador5 +=1;

                            }
                    }

                    if(i+1<tamanho){
                        if(k>0){
                            switch(filledField[i+1,k-1])
                                {
                                    case 8:
                                    contador4 +=1;
                                    case 9:
                                    contador5 +=1;
                                }
                            }
                            switch(filledField[i+1,k])
                                {
                                    case 8:
                                    contador4 +=1;
                                    case 9:
                                    contador5 +=1;
                                }
                if(k+1<tamanho){
                        switch(filledField[i+1,k+1])
                        {
                            case 8:
                            contador4 +=1:
                            case 9:
                            contador5 +=1;

                        }

              }
                if(
                ((filledField[i,k] == 1) && (contador4 == 1) && (contador5 == 0)) || 
                ((filledField[i,k] == 1) && (contador4 == 1) && (contador5 == 1)) ||
                ((filledField[i,k] == 2) && (contador4 == 2) && (contador5 == 0)) ||
                ((filledField[i,k] == 3) && (contador4 == 2) && (contador5 == 1)) ||
                ((filledField[i,k] == 3) && (contador4 == 1) && (contador5 == 2)) ||
                ((filledField[i,k] == 3) && (contador4 == 3) && (contador5 == 0))
                )
                {
                if(i>0){
                    if(k>0){
                        if(filledField[i-1,k-1] == 8)
                            {
                                filledField[i-1,k-1] = 9;
                            }
                    }
                }
                if(filledField[i-1,k] == 8)
                    {
                        filledField[i-1,k] == 9;
                    }
                if(k+1<tamanho){
                    
                    if(filledField[i-1,k+1] ==8)
                            {
                                filledField[i-1,k+1] ==9;
                            }
                    }

                    if(k>0){
                        if(filledField[i,k-1] ==8)
                            {
                                filledField[i,k-1] ==9;
                            }
                    }
                    if(k+1<tamanho){
                        if(filledField[i,k+1] == 8)
                            {
                                filledField[i,k+1] == 9;
                            }
                    }

                    if(i+1<tamanho){
                    if(k>0){
                        if(filledField[i+1,k-1] == 8)
                            {
                                filledField[i+1,k-1] == "*";
                            }
                    }
                    if(filledField[i+1,k] == 8)
                            {
                                filledField[i+1,k] == 9;
                            }
                    if(k+1<tamanho){
                            if(filledField[i+1,k+1] == 8)
                            {
                                filledField[i+1,k+1] == 9;
                            }

                    }
                        
                    }
                    }
                }
            }
        }


    public static int Numerar(int filledField){
     //Descobre o valor do local.
    for(int i =1; i<10; i++){
        for(int k=1; k<10; k++){
            if((filledField[i,k]!=9)&&(filledField[i,k]!=8)){
                if(i>0){
                    if(k>0){
                        if(filledField[i-1,k-1]== 9){
                            filledField[i,k]++;
                        }
                    }
                if(filledField[i-1,k]== 9){
                    filledField[i,k]++;
                } 
                if(k+1<10){
                    if(filledField[i-1,k+1]==9){
                        filledField[i,k]++;
                    }
                }
                }
            }
        if(k>0){
            if(filledField[i,k-1]==9){
                filledField[i,k]++;
            }
        }
        if(k+1<10){
            if(filledField[i,k+1]==9){
                filledField[i,k]++;
            }
        }

        if(i+1<10){
            if(k>0){
                if(filledField[i+1,k-1]==9){
                filledField[i,k]++;
                }
            }
            if(filledField[i+1,k]==9){
                filledField[i,k]++;
            }
            if(k+1<10){
                if(filledField[i+1,k+1]==9){
                    filledField[i,k]++;
                }
            }
        }
      }
      }
    }
 
   
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
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
                        string campoTeste = campoMinado.Tabuleiro.Replace("\n", ""); 
                        campoTeste = campoTeste.Replace("\r", "");
                        array[i,j] = campoTeste[x];    
                        x+=1;
                    }
                }
                
                int[,] filledField = new int[10,10];

                for(int i=1;i < 10;i++)
                {
                    for(int j=1;j < 10;j++)
                    {
                        if(array[i,j] == '0' || array[i,j] == '1' || array[i,j] == '2' || array[i,j] == '3'){
                            filledField[i,j]= Int32.Parse(array[i,j]);
                        }
                        else if (array[i,j] == '-'){
                            filledField[i,j] = 8;
                        }
                        else{
                            filledField[i,j] = 9;
                        }
                        
                        Console.WriteLine(filledField[i,j]);

                    }
                }
                Numerar(filledField);
               
                              
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


