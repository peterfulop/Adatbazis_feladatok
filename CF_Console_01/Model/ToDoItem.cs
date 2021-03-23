using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF_Console_01.Model
{
    public class ToDoItem
    {

        public ToDoItem()
        {
            IsDone = false;
            Opened = DateTime.Now;
            Closed = null;
        }

        public int id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime Opened { get; set; }
        public DateTime? Closed { get; set; }

        /// Adatbázis módosítás CF alatt => Migration

        public Severity Severity {get;set;}
        public int SeverityID { get; set; } // Idegen kulcs meghatározás, manuálisan! 
    }
}
