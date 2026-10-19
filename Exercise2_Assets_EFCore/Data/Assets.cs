using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Exercise2_Assets_EFCore.Data
{
    public class Assets
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateOnly DateAcquired { get; set; }
        public bool InUse { get; set; }
        public decimal PurchasePrice { get; set; }

        public Assets()
        {
        }

        public Assets(string name,
            string location,
            DateOnly dateAcquired,
            bool inUse,
            decimal purchasePrice)
        {
            Name = name;
            Location = location;
            DateAcquired = dateAcquired;
            InUse = inUse;
            PurchasePrice = purchasePrice;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Location: {Location}, DateAcquired: {DateAcquired}, InUse: {InUse}, PurchasePrice: {PurchasePrice}";
        }
    }
}
