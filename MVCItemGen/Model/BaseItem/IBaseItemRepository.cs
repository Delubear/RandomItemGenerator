using RPGItemGenerator.ItemGeneration;
using System.Collections.Generic;

namespace MVCItemGen.Model
{
    public interface IBaseItemRepository
    {
        List<Item> BaseItemRepository { get; }
        void AddRandomItem();
        void Reset();
        void SaveChanges();
    }
}
