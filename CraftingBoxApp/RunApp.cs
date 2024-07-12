namespace CraftingBoxApp
{
    internal class RunApp
    {
        public void Run()
        {
            // Task was to create a crafting table of sorts, who gets a random supply of wood.
            // It instantly crafts something with the wood it has remaining and with the ones he got.

            var rand_woodAmount = new Random();

            var craftingTable = new CraftingBox();


            for (int i = 0; i < 10; i++) 
            {
                // Translation: You have crafted: (item)
                Console.WriteLine("Vytvořil jsi: " + craftingTable.CraftMeSomething(rand_woodAmount.Next(0,11)));
            }

            int[] amountOfStuff = craftingTable.HowMuchCreated();

            // --- Translation ---
            // Amount of crafted items:
            // Plank:
            // Chair:
            // Table:
            // Total:
            Console.WriteLine("Počet vytvořených předmětů: ");
            Console.WriteLine("Prkna: " + amountOfStuff[0]);
            Console.WriteLine("Židle: " + amountOfStuff[1]);
            Console.WriteLine("Stůl: " + amountOfStuff[2]);
            Console.WriteLine("Celkem: " + (amountOfStuff[0] + amountOfStuff[1] + amountOfStuff[2]));
        }
    }
}
