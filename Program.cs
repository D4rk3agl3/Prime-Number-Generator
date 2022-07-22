double numbertocheck = 1;
St:
numbertocheck++;
for (int i = 2; i <= numbertocheck; i++)
{
    if((numbertocheck % i) == 0 && i == numbertocheck){
        Console.WriteLine(numbertocheck + " IS a prime.");      
        goto St;
        break;
    }
    else if((numbertocheck % i) == 0 && i < numbertocheck){
        goto St;
        break;
    }
}
