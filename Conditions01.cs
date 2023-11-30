/*using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            // erste ausgabe
            Console.WriteLine("Welcome! Tickets are 5 $. Please insert cash!");
            // variable cash mit int als wert versehen
            int cash = Convert.ToInt32(Console.ReadLine());
            // if statements für cash zuweisen
            if (cash <5)//wenn cash kleiner 5, ->zu wenig
            {
                Console.WriteLine("Thats not enought money.");
            } // wenn cash genau 5,-> hier ist dein ticket
            else if (cash == 5)
            {
                Console.WriteLine("Here is your Ticket");
            }// wenn cash mehr als 5->dann rückgabe geld ausrechen 
            else
            {// neue varibale change wert ist gegebenes geld cash minus tikcetpreis (5)
                int change = cash - 5;
                Console.WriteLine("Here is your Ticket and " + change + " dollars in change.");
            }
            //wait before closing
            Console.ReadKey();
        }
    } 
}*/

/* if statments könne auch ineinader geschachtelt werden das nennt sich nesting
beispiel
if(age >=18)// wenn hier noch eine 2. condition erfraget werden soll 
//-> &&(=and) und dann muss beides zutreffen damit das if erfüllt ist
// or = || 
{
    if(height >=160cm)
    {
        Console.WriteLine("You can enter the Rollercoaster.);
    }
}*/