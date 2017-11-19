using System;
using System.Linq;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Item
    {
        private string GetTypeOf(Item itm)
        {
            string type = "";

            if (ItemType == ItemTypes.Weapon)
            {
                var wpnType = itm.GetType().GetProperty("WeaponType").GetValue(itm);
                type = wpnType.ToString();
            }
            else if (ItemType == ItemTypes.Armor)
            {
                var armType = itm.GetType().GetProperty("ArmorType").GetValue(itm);
                type = armType.ToString();
            }
            else if (ItemType == ItemTypes.Potion)
            {
                type = ItemTypes.Potion.ToString();
            }

            return type;
        }

        private void GetPropertys(int number, Item itm)
        {
            string typeOfName = GetTypeOf(itm);
            var propertyCreator = new SecondaryPropertiesList().SecondaryPropertiesSet[Rarity.ToString() + ":" + typeOfName];

            for (int i = 0; i < number; i++)
            {
                if (propertyCreator.Count() >= 1)
                {
                    var pc = propertyCreator.ElementAt(r.Next(0, propertyCreator.Count()));
                    propertyCreator.Remove(pc.Key);

                    Type type = Type.GetType("RPGItemGenerator.ItemGeneration." + pc.Key);
                    var newProp = (SecondaryProperties)Activator.CreateInstance(type);

                    if (!SecondaryProps.ContainsKey(pc.Value))
                    {
                        SecondaryProps.Add(pc.Value, newProp);
                    }

                    var temp = propertyCreator.Where(m => m.Value == pc.Value).ToList();
                    foreach(var tmp in temp)
                    {
                        propertyCreator.Remove(tmp.Key);
                    }
                }
            }
        }
    }
}
