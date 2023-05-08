using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEAssistant.Entities
{
    public class Country
    {
        /// <summary>
        /// Domain Model for Country
        /// </summary>
        public Guid CountryID { get; set; }
        public string? CountryName { get; set; }

    }
}
