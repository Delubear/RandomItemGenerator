using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCItemGen.Model
{
    public interface IBaseItemRepository
    {
        IEnumerable<BaseItemModel> BaseItemRepository { get; }
    }
}
