


Console.WriteLine("Enter your number :");

int number =int.Parse(Console.ReadLine());
int reminder,reverse=0;
while(number!=0){

    reminder= number % 10;
    reverse= reverse * 10 + reminder;
    number = number/10;
    
}


Console.WriteLine($"Reverse number : {reverse}");
