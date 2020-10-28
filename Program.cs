using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            string sair="";
            do
            {
            Double renda=0, parcela=0, credito=0, Valor=0;
            int Nparc=0;
            Console.Clear();
            Box("Analise de Credito",6,15,15,0);

            print("Valor a ser financiado : R$",15,0,1,4);         
            Valor = Convert.ToDouble(Console.ReadLine());

            print("Renda Mensal ----------: R$",15,0,1,5);         
            renda = Convert.ToDouble(Console.ReadLine());

            print("Numero de parcelas ----:",15,0,1,6);         
            Nparc = Convert.ToInt16(Console.ReadLine());

            credito = ((renda/100)*30);
            parcela = (Valor/Nparc);

            if (parcela > credito)
             { print("Seu financiamento foi negado",15,4,35,4);}
             else {print("Finaciamento AUTORIZADO",0,2,35,4);}

             print("Outro?(s)",15,0,1,9);
             sair=Console.ReadLine().ToUpper();
            } while(sair=="S");
            Console.Clear();
        }


         static void Box( String S2,int Cor_Caixa, int Cor_Letra, int X, int Y)//  Texto dentro da caixa    
        {
         int tamanho = S2.Length; 
         Console.SetCursorPosition(X, Y);
         string lin = new string('*', tamanho+4); 
         string vazio = new string(' ',tamanho+2);
           // imprime Caixa
         ConsoleColor CorCaixa = (ConsoleColor)Cor_Caixa;
         Console.ForegroundColor = CorCaixa;
         Console.SetCursorPosition(X, Y);Console.WriteLine(lin);         
         Console.SetCursorPosition(X, Y+1);Console.Write($"*{vazio}*");         
         Console.SetCursorPosition(X, Y+2);Console.Write(lin);   
          // imprime Titulo
         ConsoleColor CorLetra = (ConsoleColor)Cor_Letra;
         Console.ForegroundColor = CorLetra;
         Console.SetCursorPosition(X+2, Y+1);
         Console.WriteLine(S2);
         //proxima coordenadas        
         Console.ResetColor();  
         Console.SetCursorPosition(0, Y+4);
        }// Fecha Box

       static void print(String S, int COR_Caracter,int COR_Fundo, int X,int Y)
        {
         ConsoleColor CorC = (ConsoleColor)COR_Caracter;
         ConsoleColor CorF = (ConsoleColor)COR_Fundo;
         Console.ForegroundColor = CorC;
         Console.BackgroundColor = CorF;
         Console.SetCursorPosition(X, Y);
         Console.Write(S);
         Console.ResetColor();
        }//fecha print
    }
}
