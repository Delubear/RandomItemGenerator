﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCItemGen.Model.BaseItem
{
    public interface iSarahRepo
    {
        List<SarahsItem> BaseSarahRepo { get; set; }
        void SaveChanges();
    }
}
