using StaffMembers.Core.Enums;
using StaffMembers.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StaffMembers.Core.Entitties
{
    public abstract class Person : Identifiable, IPerson
    {

        private string firstName;
        private string lastName;
        private string accountNumber;
        private int hoursAWeek;

        public int HoursAWeek
        {
            get { return hoursAWeek; }
            set {
                if (value < 10 || value >= 38) throw new Exception("Je kan niet meer dan 38uren per week werken of minder dan 10");
                hoursAWeek = value; 
            }
        }


        public string AccountNumber
        {
            get { return accountNumber; }
           private set {

                if (string.IsNullOrWhiteSpace(value)) throw new Exception("Rekening nummer moet uit 18 cijfers bestaan.");
                else if (value.Trim().All(char.IsNumber)) accountNumber = value; 
                else throw new Exception("Enkel cijfers invullen");
                
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("De voornaam mag niet korter zijn dan 2 letters");
                else if (value.Trim().All(char.IsLetter)) firstName = value;
                else throw new Exception("Enkel letters invullen");   
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("De familieNaam mag niet korter zijn dan 2 letters");
                else if (value.Trim().All(char.IsLetter)) lastName = value;
                else throw new Exception("Enkel letters invullen");
            }
        }

        public Contract Contract { get; set; }
        public Adress Adress { get; private set; }



        public Person(string firstName, string lastName, string accountNumber,
            int hoursAWeek, Contract contract,Adress adress, Guid? id = null) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            AccountNumber = accountNumber;
            HoursAWeek = hoursAWeek;
            Contract = contract;
            Adress = adress;
        }

        public bool IsUnique(IEnumerable<IPerson> collection, out IPerson matchingPerson)
        {
            matchingPerson = null;
            foreach (IPerson collectable in collection)
            {
                if (Id == collectable.Id && collectable is Person person)
                {
                    matchingPerson = person;
                    return false;
                }
            }
            return true;
        }

        public bool changeAdress(Adress newAdress)
        {
            bool update = false;
            if (newAdress != null) {               
            Adress = newAdress;
            update = true;             
            }
            return update;
        }

        public void changeAccountNumber(string newNumber)
        {
            AccountNumber = newNumber;
        }
    }
}
