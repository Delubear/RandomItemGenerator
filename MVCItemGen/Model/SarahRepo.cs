using MVCItemGen.Model.BaseItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCItemGen.Model
{
    public class SarahRepo : iSarahRepo
    {
        // public List<SarahsItem> BaseSarahRepo => throw new NotImplementedException();

        public void SaveChanges()
        {
            _sarahDbContext.SaveChanges();
        }


        public SarahDBContext _sarahDbContext;
        
        public SarahRepo(SarahDBContext sarahDbContext)
        {
            _sarahDbContext = sarahDbContext;

        }

        public List<SarahsItem> BaseSarahRepo
        {
            get
            {
                return _sarahDbContext.SarahsItems.ToList();
            }
            set
            { }
        }

        public SarahRepo()
        {

        }
    }
}
