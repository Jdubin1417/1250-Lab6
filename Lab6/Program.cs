/**
*--------------------------------------------------------------------
* File name: Program.cs
* Project name: lab6
*--------------------------------------------------------------------
* Author’s name and email: Justin Dubin, dubinj@etsu.edu
* Course-Section: CSCI 1250-001
* Creation Date: 31 Mar 2022
*
-------------------------------------------------------------------
*/
//-----------------------------------------------------------
ShowCharacter("New York", 8);
//----------------------------------------------------------
Console.WriteLine(CalculateRetail());
//-----------------------------------------------------------------
for (int i=80; i <= 100; i++)
{
    System.Console.WriteLine($"{i} converted to Celsius is {Math.Round(Celsius(i), 2)}");
}
//------------------------------------------------------------------------------------------
IsPrime();
//------------------------------------------------------------------------------------------
static void ShowCharacter(string word, int place)
{
    if(place > word.Length)
    {
        System.Console.WriteLine("The place you are looking for does not exist! ");
    }
    else if(place <= 0)
    {
        System.Console.WriteLine("That does not make sense! ");
    }
    else
    {
        System.Console.WriteLine(word[place - 1]);
    }
}
//---------------------------------------------------------------------------------
static double CalculateRetail()
{
    System.Console.Write("Enter item's wholesale cost here: ");
    double cost = Convert.ToDouble(Console.ReadLine());

    System.Console.Write("Enter item's markup percentage here: ");
    double percent = Convert.ToDouble(Console.ReadLine())/100.0;

    //cost + markup cost
    return (cost + (cost * percent));
}
//------------------------------------------------------------------------------------------
static double Celsius(int f)
{
    return ((5.0/9.0) * (f - 32.0));
}
//------------------------------------------------------------------------------------------
static void IsPrime()
  {  
          int number, i, m=0, test=0;    
          Console.Write("Enter the Number to check if Prime: ");    
          number = Convert.ToInt32(Console.ReadLine());  
          m=number/2;    
          for(i = 2; i <= m; i++)    
          {    
           if(number % i == 0)    
            {    
             Console.Write("Number is not a Prime Number.");    
             test=1;    
             break;    
            }    
          }    
            if (test==0) 
             {
             Console.Write("Number is a Prime Number.");
             }   
               
     }  
