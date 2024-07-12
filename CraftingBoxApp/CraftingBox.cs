namespace CraftingBoxApp
{
    internal class CraftingBox
    {
        // This class keeps track of wood suply and it's inventory.
        private int remainingWood = 0;
        private string[] items = new string[3] {"prkno", "židle", "stůl"};
        private int[] count = new int[3];
        public string CraftMeSomething(int woodAmount)
        {
            
            if (woodAmount + remainingWood >= 7)
            {
                remainingWood = woodAmount + remainingWood - 7;
                count[2]++;
                return items[2];
            }
            else if (woodAmount >= 5)
            {
                remainingWood = woodAmount + remainingWood - 5;
                count[1]++;
                return items[1];
            }
            else if (woodAmount >= 3) 
            {
                remainingWood = woodAmount + remainingWood - 3;
                count[0]++;
                return items[0];
            }
            else
            {
                return string.Empty;
            }
        }

        public int[] HowMuchCreated()
        {
            return count;
        }
    }
}
