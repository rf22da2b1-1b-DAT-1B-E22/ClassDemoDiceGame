// See https://aka.ms/new-console-template for more information
using ClassDemoDiceGame;

Console.WriteLine("UserStory:");
Console.WriteLine("Som Spiller ønsker jeg at slå med et rafleBæger med to terninger," +
    "hvor jeg vinder hvis summen  af de to terninger er syv");

Spiller spiller = new Spiller("Peter");


for (int i = 0; i < 100; i++)
{


    if (spiller.Spil())
    {
        Console.WriteLine("jubii " + spiller.Navn + "har vundet");
    }
    else
    {
        Console.WriteLine("ØV " + spiller.Navn + " har tabt");
    }

}


