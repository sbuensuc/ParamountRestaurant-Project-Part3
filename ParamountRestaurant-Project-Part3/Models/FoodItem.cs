namespace ParamountRestaurant_Project_Part3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoodItem
    {
        [Key]
        public int FoodId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }
    }
}
