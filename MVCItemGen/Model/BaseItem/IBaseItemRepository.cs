using RPGItemGenerator.ItemGeneration;
using System.Collections.Generic;

namespace MVCItemGen.Model
{
    public interface IBaseItemRepository
    {
        IEnumerable<Item> BaseItemRepository { get; }
    }
}
