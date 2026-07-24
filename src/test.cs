/*
Simple sine calculator using Bhaskara's approximation, with a relatively small margin for error.
Code runs in groups of 5 and adds one the number of degrees each iteration.
*/

int nAngle(int inp)
{
    int PoR=1;
    if (inp>0)
    {
        PoR = (int)System.Math.Floor((double)inp / 180);
        inp-=180*PoR;
    }
    if (inp<0)
    {
        PoR = (int)System.Math.Ceiling((double)inp / 180);
        inp-=180*PoR;
    }
    return(inp);
}
float Calculation(int s)
{
    int minuss = 1;
    int nmrt = 1;
    int dnmtr = 1;
    minuss = s*180-s*s;
    nmrt = 4*minuss;
    dnmtr = 40500-minuss;
    float fin = ((float)nmrt/dnmtr);
    if(s>180 && s<360)
    {
        fin *= -1;
    }
    return((float)fin);
}
int q = 1;
while(true)
{
    
    for(int i=0; i<5; i++)
    {
        Console.Write("Random Angle: ");
        Console.WriteLine((int)q);
        Console.WriteLine((float)Calculation(nAngle(q)));
        q+=1;
    }

    Console.Write("5 iterations! resetting");
    Console.Write(".");
    Thread.Sleep(700);
    Console.Write(".");
    Thread.Sleep(700);
    Console.Write(".");
    Thread.Sleep(800);
    Console.Clear();
}
