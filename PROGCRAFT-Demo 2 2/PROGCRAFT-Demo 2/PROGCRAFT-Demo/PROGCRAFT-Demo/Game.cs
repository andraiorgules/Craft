using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static PROGCRAFT_Demo.Utility;
using static PROGCRAFT_Demo.Utilities.LoadData;
using static PROGCRAFT_Demo.NPC;

namespace PROGCRAFT_Demo
{
    class Game
    {
        Person Player;
        NPC Trader;

        public void Run()
        {
            Player = new Person();
            Trader = new NPC();

            SetUpGame();
            ShowWelcome();
            Pause();
            Print("This is what is in your inventory...");
            Print(ShowAllItemsInList(Player.Inventory));

            Print("This is what the salesman has in store...");
            Print(ShowAllItemsInList(Trader.Store));
            Trader.Sell(Player);
            Print("This is what is in your inventory...");
            Print(ShowAllItemsInList(Player.Inventory));

            Pause();
        }

        private void SetUpGame()
        {
            Player.Name = "Anonymous Player";
            Title = "Crafting System Demo";
        }

        private void ShowWelcome()
        {
            Title = "Crafting System Demo";
            Print("What is your name?");
            Player.Name = Console.ReadLine();
            
            Print($"Welcome {Player.Name}");
           
            Print(LoadTextFromFile("../../data/welcome.txt"));
        
            Print(LoadTextFromFile("../../data/instructions.txt"));

            Trader.Store = LoadLinesFromFiles("../../data/store.txt"); 
        }

    }
}
