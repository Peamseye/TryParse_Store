using System;



ToolBox.WriteCentered("Tryparse Store");
ToolBox.WriteCentered("");
ToolBox.WriteCentered("");

//-------------------------

//Int-satser som uppdateras efter varje återställning av loopen
int currency = 100;
//Valuta
int amount = 0;
//Mängd frukter
int price = 0;
//Bestämmer priset på den frukt användaren valt att köpa
// 

//Introduktion
ToolBox.WriteCentered("Hello! Feel free to purchase some of my exotic Fruits!");
Console.WriteLine("");
ToolBox.WriteCentered("I have three different fruits you can choose from, so make sure you have enough money.");


//-------------------------
//Programmets loop. Tillåter användaren att starta om loopen för att köpa fler produkter
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

    //Fruit = Första svaret på frågan
    string fruit = Console.ReadLine();
    fruit = fruit.ToLower();

    //Tvingar användaren att välja mellan a, b eller c.
    while (fruit != "a" && fruit != "b" && fruit != "c")
    {
    Console.Clear();
    
    ToolBox.WriteCentered($"You have {currency}$ left.");
    ToolBox.WriteCentered("");
    ToolBox.WriteCentered("What fruit do you want to purchase?");
    ToolBox.WriteCentered("");
    ToolBox.WriteCentered("a = Apple (5$)     b = Orange (10$)     c = Melon (15$)");
    
    fruit = Console.ReadLine();
    }

    //Bestämmer värdet på varje frukt beroende på svaret av "fruit"
    if (fruit == "a")
    {
        price = 5;
        
    }

    if (fruit == "b")
    {
        price = 10;
        
    }

    if (fruit == "c")
    {
        price = 15;
        
    }


    ToolBox.WriteCentered("How many do you want to purchase?");

    string input = Console.ReadLine();


    //-------------------------

    //Bestämmer mängden frukter som ska köpas av användaren. 
    bool success = int.TryParse(input, out amount);

    //Startar en loop så länge användaren inte skriver in en siffra
    while (success != true)
    {
        Console.Clear();
        ToolBox.WriteCentered("How many do you want to purchase?");
        input = Console.ReadLine();


        success = int.TryParse(input, out amount);
    }



    //Kollar om användaren har tillräckligt stor summa att köpa en mängd frukt. Om den inte har råd, startas loopen om. Om den har råd, subtraheras värdet från totala summan pengar.
    if (currency < amount * price)
    {
        ToolBox.WriteCentered("Sorry, you cannot afford to buy this.");
        amount = 0;
    }
    else {

     currency = currency - amount * price;
     }
    

    
    //Kollar om användaren har några pengar kvar. Om den har pengar, säger programmet till användaren mängden frukt, samt den totala summan som återstår.
    if (currency < 0)
    {
        ToolBox.WriteCentered("Sorry, you cannot afford to buy any more products.");
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
    
    //Startar en loop som fortsätter så länge användaren inte skriver in a eller b. Loopen fortsätter så länge programmets loop är aktiv, och stannar om användaren väljer att avsluta programmet.
    while (answer != "a" && answer != "b" && game == true)
    {

        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        ToolBox.WriteCentered("Do you want to purchase more?");
        Console.WriteLine("");
        ToolBox.WriteCentered("a = yes                 b = no");

        answer = Console.ReadLine();
    }

//Bestämmer om användaren vill återställa loopen och köpa fler frukter, eller om loopen ska avslutas och programmet ska stängas.
    if (answer == "a")
    {
        Console.Clear();
        game = true;
    }

    if (answer == "b")
    {
        ToolBox.WriteCentered("You leave the store.");
        ToolBox.WriteCentered("Press [ENTER] To Exit.");
        game = false;
    }

}

//Avslutar loopen och stänger ner konsolen.
if (game == false)
{
    Console.ReadLine();
}