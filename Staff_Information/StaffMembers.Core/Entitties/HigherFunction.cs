using StaffMembers.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Text.RegularExpressions;

namespace StaffMembers.Core.Entitties
{
    public abstract class HigherFunction : Identifiable, IPerson
    {

        private string firstName;

        public string MyProperty
        {
            get { return firstName; }
            set {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("De voornaam mag niet korter zijn dan 2 letters");
                else if (Regex.IsMatch(value, "[^A-Za-z_ŠšČčŽžĆćĐđ]")) firstName = value;
                else throw new Exception("Enkel letters invullen");
                
                 
            
            }
        }

        public string FirtName { get; }
        public string LastName { get; }
        public string Adress { get; }
        public string AccountNumber { get; }
        public int HoursAWeek { get; set; }
        public Contract Contract { get; set; }
        public int OverTime { get; set; }
    }
}
