using System.Text;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class RunItemGen
    {
        public Item GetNewRandomItem()
        {
            if(itemBaseName.Count < 1)
            {
                GenerateLists();
            }
            var _itemBaseName = itemBaseName;
            return GetItemType(itemBaseName);
        }

        public Item GetNewRandomItem(string rarity)
        {
            if (itemBaseName.Count < 1)
            {
                GenerateLists();
            }
            var _itemBaseName = itemBaseName;
            return GetItemType(itemBaseName, rarity);
        }

        public string GetItemStatsAsString(Item itemToProcess)
        {
            StringBuilder stB = new StringBuilder();
            stB.AppendLine($"Name: {itemToProcess.Name}");
            stB.AppendLine($"Value: {itemToProcess.Value}");
            stB.AppendLine($"Description: {itemToProcess.Description}");
            stB.AppendLine($"Rarity: {itemToProcess.Rarity}");
            stB.AppendLine($"Type: {itemToProcess.ItemType}");
            stB.AppendLine($"Durability: {itemToProcess.CurrentDurability}/{itemToProcess.MaxDurability}");

            foreach (var prop in itemToProcess.SecondaryProps.Values)
            {
                stB.AppendLine($"Has Property: " + prop.PropDescription);
            }

            if (itemToProcess.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Armor")
            {
                stB.AppendLine($"ArmorType: " + itemToProcess.GetType().GetProperty("ArmorType").GetValue(itemToProcess));
                stB.AppendLine($"ArmorValue: " + itemToProcess.GetType().GetProperty("ArmorValue").GetValue(itemToProcess));
            }
            else if (itemToProcess.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Weapons")
            {
                stB.AppendLine($"WeaponCategory: {itemToProcess.GetType().GetProperty("WeaponCat").GetValue(itemToProcess)}");
                stB.AppendLine($"WeaponType: {itemToProcess.GetType().GetProperty("WeaponType").GetValue(itemToProcess)}");
                stB.AppendLine($"Damage: {itemToProcess.GetType().GetProperty("DamageValue").GetValue(itemToProcess)}");
                stB.AppendLine($"Damage Type: {itemToProcess.GetType().GetProperty("DamageType").GetValue(itemToProcess)}");
                stB.AppendLine($"Accuracy: {itemToProcess.GetType().GetProperty("Accuracy").GetValue(itemToProcess)}");
            }
            else if (itemToProcess.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Potions")
            {
                stB.AppendLine($"Effects: {itemToProcess.GetType().GetProperty("Effect").GetValue(itemToProcess)}");
            }
            else if (itemToProcess.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Jewelry")
            {
                stB.AppendLine($"Effects: {itemToProcess.GetType().GetProperty("Effect").GetValue(itemToProcess)}");
                stB.AppendLine($"Jewelry Type: {itemToProcess.GetType().GetProperty("JewelryType").GetValue(itemToProcess)}");
            }

            return stB.ToString();
        }        
    }
}
