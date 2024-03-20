using System;

class Program
{
    static void Main()
    {
        string palavra, Invertida;
      
        Console.WriteLine("Digite um palavra: ");
        palavra = Console.ReadLine();
        /*Transforma em array de caracteres*/
        char[] caracteres = palavra.ToCharArray();
        /*Ve quantas letras tem essa palavra*/
        int tamanho = caracteres.Length;
      /*Começa da primeira letra e só vai até a metade da palavra*/
        for (int i = 0; i < tamanho / 2; i++)
        {
          
          /*Armazena o caracter*/
            char aux = caracteres[i];
          /*substituí o caractere atual pelo caractere simétrico no final da palavra.*/
            caracteres[i] = caracteres[tamanho - i - 1];
          /*substituí o caractere simétrico pelo caractere armazenado aux*/
            caracteres[tamanho - i - 1] = aux;
          Console.WriteLine("O caracter atual é: {0}", aux);
          Console.WriteLine("O caracter Simetrico é: {0}", caracteres[i]);
          Console.WriteLine("");
        }
        
        Invertida = new string(caracteres);
        Console.WriteLine("A palavra invertida é: ", Invertida);
    }
}
