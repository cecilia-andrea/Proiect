using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vaida_Cecilia.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        [Column(TypeName ="decimal(6,2)")]
        public decimal Pret { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data publicării")]
        public DateTime PublishingDate { get; set; }
        public int PublisherID { get; set; }

        public Publisher Publisher { get; set; }
         
        public ICollection<CarCategory> CarCategories { get; set; }
    }
}
