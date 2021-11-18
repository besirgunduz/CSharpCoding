using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulamasi
{
    public class Card
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contant { get; set; }
        public int? AssignedPersonId { get; set; }
        public Size Size { get; set; }
        public virtual AssignedPerson AssignedPerson { get; set; }
    }
}
