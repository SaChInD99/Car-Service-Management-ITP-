using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliermanage
{
    class supplier
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Item_Id { get; set; }
        public string ItemType { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }

        public supplier(string id, string companyName, string address, string country, string contactNumber, string email, string item_Id, string itemType, string description, string date)
        {
            Id = id;
            CompanyName = companyName;
            Address = address;
            Country = country;
            ContactNumber = contactNumber;
            Email = email;
            Item_Id = item_Id;
            ItemType = itemType;
            Description = description;
            Date = date;
        }
    }
}

