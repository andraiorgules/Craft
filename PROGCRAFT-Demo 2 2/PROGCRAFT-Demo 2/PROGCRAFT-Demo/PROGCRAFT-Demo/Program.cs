/* PROG 201 Craft Project
 * Your Name: Andrada Iorgulescu
 * Date: March 27, 2022
 * Credits: 
 * Recipe List in Recipe Class, Inventory List in Person Class, and Ingredients enum in Item class made with information from 
 * https://stackoverflow.com/questions/23208087/c-sharp-crafting-logic ;
 * IItemContainer class, ItemCount + AddItem + RemoveItem + ContainsItem + + Craft + CanCraft Methods in Person class created with information from 
 * https://www.youtube.com/watch?v=gZsJ_rG5hdo ;
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static PROGCRAFT_Demo.Utility;

namespace PROGCRAFT_Demo
{
    class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.Run();

            PROGCRAFT_Demo.Utilities.Display.Print("Hello!");
        }
    }
}
