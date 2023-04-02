using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ООТПиСП_ЛР4
{
    internal class Organization
    {
        public string? OrganizationName;
        public Organization(string ON)
        {
            OrganizationName = ON;
        }

        public override string ToString()
        {
            return $"{OrganizationName}";
        }
    }
}
