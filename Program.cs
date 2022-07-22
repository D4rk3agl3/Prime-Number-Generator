double numbertocheck = 1;
St:
numbertocheck++;

if(numbertocheck == 1000){
    break;
}
else{
    goto Done;
}




Done:
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
