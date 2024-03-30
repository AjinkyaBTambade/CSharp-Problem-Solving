
int factorial(int a){
   int fact=1;
     for(int i=1;i<=a;i++){
        
      fact=fact*i;
     }
return fact;
 }



int detectStrong(int num){
    int sum=0;
    int rem=0;
    while(num!=0){
        rem=num%10;
        sum=sum + factorial(rem);
        num/=10;
    }
    return sum;
}

int num=-1;
int sum = detectStrong(num);
Console.WriteLine(sum);

if(num==sum){
    Console.WriteLine("Given number is strong number");
}
else{
    Console.WriteLine("not strong number");
}

