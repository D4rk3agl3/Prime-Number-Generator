double numbertocheck = 59;
for (int i = 2; i <= numbertocheck; i++)
{
    if((numbertocheck % i) == 0 && i == numbertocheck){
        Console.WriteLine(numbertocheck + " IS a prime.");
        break;      
    }
    else if((numbertocheck % i) == 0 && i < numbertocheck){
        Console.WriteLine(numbertocheck + " is NOT a prime.");
        break;
    }
}

    
