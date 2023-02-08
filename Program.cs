// See https://aka.ms/new-console-template for more information
int number1 = 0;
int number2 = 0;
Console.WriteLine("PRIMER NÚMERO:");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("SEGUNDO NÚMERO:");
number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("LA SUMA ES:"+number1+"+"+number2+"="+(number1+number2));
Console.WriteLine("LA RESTA ES:"+ number1+ "-"+ number2 + "=" + (number1-number2));
Console.WriteLine("LA MULTIPLICACIÓN ES:"+ number1+ "*"+ number2 + "=" + (number1*number2));
Console.WriteLine("LA DIVISIÓN ES:"+ number1+"/"+ number2+ "=" + (number1/number2));
Console.WriteLine("EL RESIDUO ES:" + (number1%number2));
