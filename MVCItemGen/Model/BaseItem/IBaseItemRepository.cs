using RPGItemGenerator.ItemGeneration;
using System.Collections.Generic;

namespace MVCItemGen.Model
{
    public interface IBaseItemRepository
    {
        List<Item> BaseItemRepository { get; }
        Item AddRandomItem();
    }
}
