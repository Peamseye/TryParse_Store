using System;



ToolBox.WriteCentered("Tryparse Store");

//-------------------------

int currency = 100;
//Beräknar valutan genom loopen.
int amount = 0;

int fruit1 = 5;
// fruit1 = apple

int fruit2 = 10;
// fruit2 = orange

int fruit3 = 15;
// fruit3 = melon
//Int-satser som uppdateras efter varje återställning av loopen

ToolBox.WriteCentered("Hello! Feel free to purchase some of my exotic Fruits!");
Console.WriteLine("");
ToolBox.WriteCentered("I have three different fruits you can choose from, so make sure you have enough money.");
//Introduktion


//-------------------------
bool game = true;
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
    
    if (fruit == "a")
    {
  currency = currency - amount * fruit1;
    }

    if (fruit == "b")
    {
  currency = currency - amount * fruit2;
    }

    if (fruit == "c")
    {
  currency = currency - amount * fruit3;
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


}

if (game == false)
{
    Console.ReadLine();
}