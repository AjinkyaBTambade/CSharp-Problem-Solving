Console.WriteLine("Enter your number:");
int num1=int.Parse(Console.ReadLine());


Console.WriteLine("Enter your number:");
int num2=int.Parse(Console.ReadLine());

if(num1==num2){
  Console.WriteLine("Both are equal numbers");
}

else if(num1>num2)
{
  Console.WriteLine($" Biggest number is :{num1}");  
}

else{
    Console.WriteLine($" Biggest number is :{num2}"); 
}

