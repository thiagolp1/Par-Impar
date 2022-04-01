int numerod;

Console.Write("Digite um número: ");
numerod = Convert.ToInt32(Console.ReadLine());

bool  numeropar = (numerod % 2)==0;
if (numeropar)
{
       Console.WriteLine($"{numerod} Eh par"); 
       Console.ForegroundColor = ConsoleColor.Red;
       Console.Beep(); Console.Beep(); 
}  
else  
{
       Console.WriteLine($"{numerod} Eh impar");
       Console.ForegroundColor = ConsoleColor.Blue;
       Console.Beep();
}       
Console.ResetColor();