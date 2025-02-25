using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refuge.BLL.Enums;

namespace Refuge.DAL.Entities
{
    [Table("Cat")]
    public class Cat
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string Name { get; set; } = null!;
        
        [Column(TypeName = "varchar(25)")]
        public CatColor Color { get; set; }
    }
}
