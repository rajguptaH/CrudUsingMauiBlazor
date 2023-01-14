using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAndCal.Model
{
    public class UiPageTypeModel
    {
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
