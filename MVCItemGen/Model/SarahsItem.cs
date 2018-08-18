using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCItemGen.Model
{
    public class SarahsItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Type")]
        public string TypeOfItem { get; set; }
        [DataType(DataType.Date),DisplayFormat(DataFormatString ="{0:MM/dd/yy}")]
        [DisplayName("Date Added")]
        public DateTime DateAdded { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
        [DisplayName("Date Completed")]
        public DateTime? DateCompleted { get; set; }

        public SarahsItem()
        {

        }
    }
}
