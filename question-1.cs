using System;

class Program {
  public static void Main (string[] args) {
    int a = 13, k = 0, s = 0;

    while (k < a)
    {
      k = k + 1;
      s = s + k;
    }
    Console.Write("Valor da soma é: {0}", s);
  }
}
