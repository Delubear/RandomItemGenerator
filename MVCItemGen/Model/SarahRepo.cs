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

        private List<SarahsItem> _BaseSarahRepo;
        public List<SarahsItem> BaseSarahRepo
        {
            get
            {
                return _sarahDbContext.SarahsItems.ToList();
            }
            set { }
        }

        public SarahRepo()
        {
            
        }

        public void Add(SarahsItem item)
        {
            _sarahDbContext.SarahsItems.Add(item);
            SaveChanges();
        }

        public void Update(SarahsItem item)
        {
            _sarahDbContext.SarahsItems.Update(item);
            SaveChanges();
        }

        public void Delete(SarahsItem item)
        {
            _sarahDbContext.SarahsItems.Remove(item);
            SaveChanges();
        }
    }
}
