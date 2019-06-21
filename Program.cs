using System;

namespace To_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            string misturado, minusculo, maiusculo, recorte, strarandEnd, replace, old, novo, alteracao;

            int x, y, z;

            Console.WriteLine("Digite qualque frase com letras mecladas entre maiúsculas e minúsculas\n EXEMPLO: eStá FRAsE é VaLIda !");
            misturado = Console.ReadLine();

          maiusculo=misturado.ToUpper();
          minusculo=misturado.ToLower();

            Console.WriteLine("\nMisturado: " + misturado);

            Console.WriteLine("\nTo Upper: " + maiusculo );

            Console.WriteLine("\nTo Lower: " + minusculo );


            Console.WriteLine("\n \n Deseja ver apenas uma parte do digitado? se sim digite a posição de inicio");
            x = int.Parse(Console.ReadLine());

            recorte = misturado.Substring(x);

            Console.WriteLine("\n SUBSTRING = " + recorte);


            // 


            Console.WriteLine("\n \n DIGITE A POSIÇÂO QUE DESEJA INICIAR O RECORTE");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("\n \n DIGITE A POSIÇÂO QUE DESEJA FINALIZAR O RECORTE");
            z = int.Parse(Console.ReadLine());

            strarandEnd = misturado.Substring(y, z);

            Console.WriteLine("\n SUBSTRING START & AND = " + strarandEnd);


            //

            Console.WriteLine("\nVOCE DESEJA SUBSTITUIR ALGUMA LETRA OU PARTE DA FRASE? sim ou não");
            replace = Console.ReadLine();

            if (replace == "sim" || replace == "SIM")
            {
                Console.WriteLine("\nQUAL CARACTER OU PALAVRA DESEJA ALTERAR?");
                old = Console.ReadLine();
                Console.WriteLine("\nDIGITE O NOVO TEXTO");
                novo = Console.ReadLine();

                alteracao = misturado.Replace(old, novo);

                Console.WriteLine("\nATUALIZAÇÂO: " + alteracao);

            }
            else
            {
                Console.WriteLine("\n    FIM   ");
            }


        }
    }
}
