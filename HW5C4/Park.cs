using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5C4
{
    class Park
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string TypeInfo { get; set; }

        public string Facilities { get; set; }
        public decimal Fee  { get; set; }
        public int NumEmp { get; set; }
        public int NumVis { get; set; }
        public decimal Budget { get; set; }

        public string Type()
        {
            return $"Name: {Name}\nLocation: {Location}\nType of Park: {TypeInfo}"; 
        }

        public string Facility()
        {
            return $"Name: {Name}\nLocation: {Location}\nFacility: {Facilities}";
        }

        public string Cost()
        {
            return $"Cost Per Visitor: {Budget / NumVis}\nNumber of Visitors: {NumVis}";
        }


        public string Revenue()
        {
            return $"Revenue: {NumVis * Fee}";
        }

        public override string ToString()
        {
            return $"Name: {Name}\nLocation: {Location}\nType of Park: {TypeInfo}\nFacilities: {Facilities}\nFee: {Fee}\nNumber of Employees: {NumEmp}\nNumber of Visitors: {NumVis}\nAnnual Budget: {Budget} ";
        }

        public Park(string name, string location, string typeinfo, string facilities, decimal fee, int numemp, int numvis, decimal budget)
        {
            Name = name;
            Location = location;
            TypeInfo = typeinfo;
            Facilities = facilities;
            Fee = fee;
            NumEmp = numemp;
            NumVis = numvis;
            Budget = budget;

        }




    }
}
