using System;



ToolBox.WriteCentered("Tryparse Store");
ToolBox.WriteCentered("");
ToolBox.WriteCentered("");

//-------------------------

int currency = 100;
//Beräknar valutan genom loopen.
int amount = 0;

int price = 0;
// 

//Int-satser som uppdateras efter varje återställning av loopen

ToolBox.WriteCentered("Hello! Feel free to purchase some of my exotic Fruits!");
Console.WriteLine("");
ToolBox.WriteCentered("I have three different fruits you can choose from, so make sure you have enough money.");
//Introduktion


//-------------------------
bool game = true;
//Programmets loop. Tillåter användaren att starta om loopen för att köpa fler produkter
while (game == true)
{
    Console.WriteLine("");
    Console.WriteLine("");

    ToolBox.WriteCentered($"You have {currency}$ left.");
    ToolBox.WriteCentered("");
    ToolBox.WriteCentered("What fruit do you want to purchase?");
    ToolBox.WriteCentered("");
    ToolBox.WriteCentered("a = Apple (5$)     b = Orange (10$)     c = Melon (15$)");

    
    string fruit = Console.ReadLine();
    fruit = fruit.ToLower();

    while (fruit != "a" && fruit != "b" && fruit != "c")
    {
    Console.Clear();
    
    ToolBox.WriteCentered($"You have {currency}$ left.");
    ToolBox.WriteCentered("");
    ToolBox.WriteCentered("What fruit do you want to purchase?");
    ToolBox.WriteCentered("");
    ToolBox.WriteCentered("a = Apple (5$)     b = Orange (10$)     c = Melon (15$)");
    
    Console.ReadLine();
    }


    if (fruit == "a")
    {
        price = 5;
        Console.WriteLine($"{currency}");
    }

    if (fruit == "b")
    {
        price = 10;
        Console.WriteLine($"{currency}");
    }

    if (fruit == "c")
    {
        price = 15;
        Console.WriteLine($"{currency}");
    }

    ToolBox.WriteCentered("How many do you want to purchase?");

    string input = Console.ReadLine();


    //-------------------------


    bool success = int.TryParse(input, out amount);

    while (success != true)
    {
        Console.Clear();
        ToolBox.WriteCentered("How many do you want to purchase?");
        input = Console.ReadLine();


        success = int.TryParse(input, out amount);
    }






    currency = currency - amount * price;
    //Beräknar hur mycket som ska tas bort från användarens totala summa pengar

    if (currency < 0)
    {
        ToolBox.WriteCentered("Sorry, you cannot afford to buy this.");
        ToolBox.WriteCentered("Press [ENTER] to put back your product and leave the store");
        game = false;
    }
    else
    {
        ToolBox.WriteCentered($"- Purchased {amount} Fruit");
        ToolBox.WriteCentered($"You have {currency}$ left");
        
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        ToolBox.WriteCentered("Do you want to purchase more?");
        Console.WriteLine("");
        ToolBox.WriteCentered("a = yes                 b = no");
    }






    string answer = Console.ReadLine();
    answer = answer.ToLower();

    while (answer != "a" && answer != "b" && game == true)
    {

        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        ToolBox.WriteCentered("Do you want to purchase more?");
        Console.WriteLine("");
        ToolBox.WriteCentered("a = yes                 b = no");

        Console.ReadLine();
    }

    if (answer == "a")
    {
        Console.Clear();
        game = true;
    }

    if (answer == "b")
    {
        ToolBox.WriteCentered($"You leave the store with the remaining {currency}$");
        ToolBox.WriteCentered("Press [ENTER] To Exit the Store");
        game = false;
    }
//Bestämmer om användaren vill återställa loopen och köpa fler frukter, eller om loopen ska avslutas och programmet stängs ner.

}

if (game == false)
{
    Console.ReadLine();
}