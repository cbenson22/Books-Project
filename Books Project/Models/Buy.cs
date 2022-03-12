using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Project.Models
{
    public class Buy
    {
        [Key]
        [BindNever]
        public int OrderId { get; set; }
        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }
        [Required(ErrorMessage = "Please enter a name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an Address:")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter a City:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a State:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter an Zip:")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter an Country:")]
        public string Country { get; set; }

        [BindNever]
        public bool PurchaseRecieved { get; set; }

        

        

    }
}
