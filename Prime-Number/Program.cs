
Console.WriteLine("Hello, World!");
bool IsPrime(int number){
    bool status=true;
    if(number<2){
        status=false;
       return status; 
    }

    for(int i=2;i<number;i++){
        if(number%i==0){
            status=false;
            return status;
        }
    }
    return status;
}

//  Console.WriteLine("Enter your Number :");
//  int number =int.Parse(Console.ReadLine());
//  if(IsPrime(number)){
//     Console.WriteLine("Given Number is Prime Number");
//  }

//  else{
//     Console.WriteLine("Not prime number");
//  }


// prime number within range

Console.WriteLine("Enter your first Number :");
 int number =int.Parse(Console.ReadLine());

 Console.WriteLine("Enter your last  Number :");
 int number2 =int.Parse(Console.ReadLine());
for(int i=number;i<=number2;i++){

     if(IsPrime(i)){
    Console.WriteLine(i);
 }
}
