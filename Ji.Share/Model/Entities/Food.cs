using System;
using System.Collections.Generic;

namespace Ji.Model.Entities
{
    public partial class Food
    {
        public int Id { get; set; }

        public int FacId { get; set; }

        public string FoodName { get; set; }

        public string Unit { get; set; }

        public int Price { get; set; }

        public string Image { get; set; }

        public int SaleOff { get; set; }

        public int CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public bool? Active { get; set; }

        public int PriceInput { get; set; }

        public int? CategoryId { get; set; }

        public string FileName { get; set; }
    }
}