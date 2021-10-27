using System;



ToolBox.WriteCentered("Store");

//-------------------------

int currency = 100;
int amount = 0;

ToolBox.WriteCentered($"You have {currency}$, Feel free to purchase some of my exotic Fruits!");
Console.WriteLine("");
ToolBox.WriteCentered("Every fruit costs 10$, so make sure you have enough money.");

//-------------------------
bool game = true;
while (game == true)
{
    Console.WriteLine("");
    Console.WriteLine("");
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


    currency = currency - amount * 10;
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

    while (answer != "a" && answer != "b")
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