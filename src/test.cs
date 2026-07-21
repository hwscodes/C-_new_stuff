/*
Console.Write("degrees or radians?: ");
string? mode = Console.ReadLine();

if (mode != "radians" && mode!= "degrees")
{
    Console.WriteLine("Invalid mode! options are;'degrees' or 'radians'");
}
int
*/
int nAngle(int inp)
{
    int PoR = (int)System.Math.Floor((double)inp / 180);
   inp -=180*PoR;
    return(inp);
}
Console.WriteLine(nAngle(730));

/*
int inputvb = 20;
if(inputvb > 180 && inputvb < 0)
{
    int inputvc=nAngle(210);
}
*/