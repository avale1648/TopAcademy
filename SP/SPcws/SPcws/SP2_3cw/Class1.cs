using System;
namespace SP2_3cw
{
    public enum MaritalStatus
    {
        Single,Married
    }
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Person(string name, string surname, MaritalStatus maritalStatus)
        {
            Name = name;
            Surname = surname;
            MaritalStatus = maritalStatus;
        }
        public override string ToString() { return $"{Name} {Surname} {MaritalStatus}"; }
    }
}