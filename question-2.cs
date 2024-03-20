using System;

class Program {
  public static void Main (string[] args) {
    int n, a = 0, b = 1, aux=0;
    bool pertence = false;
    
    Console.WriteLine ("Sequência de Fibonacci");
    Console.WriteLine("Informe um número: ");
    n = int.Parse(Console.ReadLine());

    if(n >= 0)
    {
    Console.WriteLine("A = {0}, B = {1}, AUX = {2}", a, b, aux);
    Console.WriteLine(" ");
     while (b <= n)
        {
          if (b == n)
          {
            /*Se B chegou ao número informado*/
            pertence = true;
          }
          /*Guarda o valor de A*/
          aux = a;
          /*Guarda o valor de B*/
          a = b;
          /*Somoa = 2o digito anterior + 1o digito anterior*/
          b = aux + b;
          Console.WriteLine("A = {0}, B = {1}, AUX = {2}", a, b, aux);
          Console.WriteLine("B = aux{0} + b{1} = {2}", aux, b, b);
        }
        if (pertence)
        {
          Console.WriteLine("{0} pertence à sequência de Fibonacci.", n);
        }
        else
        {
          Console.WriteLine("{0} não pertence à sequência de Fibonacci.", n);
        }

    }else
      {
        Console.WriteLine("Número inválido");
      }
  }
}
