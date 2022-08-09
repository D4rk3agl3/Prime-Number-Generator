double numbertocheck = 1;
S: //Start
numbertocheck++;
for (int i = 2; i <= numbertocheck; i++)
{
    if((numbertocheck % i) == 0 && i == numbertocheck){
        Console.WriteLine(numbertocheck);      
        goto S;
        break;
    }
    else if((numbertocheck % i) == 0 && i < numbertocheck){
        goto S;
        break;
    }
}