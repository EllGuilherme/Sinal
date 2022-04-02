int NumeroDigitado; 
 Console.Write("Digite um numero: ");
 NumeroDigitado = Convert.ToInt32(Console.ReadLine());

  if  (NumeroDigitado <0 )
   {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine(" Esse número é negativo");
   }

  else if  (NumeroDigitado >0 )
   {
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine(" Esse número é positivo");
   }
  
  else
   {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(" Esse número é igual a Zero");
   }
      Console.ResetColor();
