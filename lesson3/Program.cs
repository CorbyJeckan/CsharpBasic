using System;
using System.Collections.Generic;
using System.Drawing;

namespace Phonebook
{
    internal class Programm
    {
        private static void Main(string[] args)
        {
            Spravka[] spravkaDataBase = new Spravka[]
                                            {
                                                new Person("Пупкин", "г. Москва, 3-я ул. Строителей, д. 22,кв. 15 ", 458934),
                                                new Person("Петров", "г. Челябинск, ул. Иванова, д. 3,кв. 90 ", 907814),
                                                new Organization("ФинСтрой №1", "г. Москва, ул. Морозова, д. 17", 675043, 3335545, "Антон Макаренко"),
                                                new Organization("ПоСтрой", "г. Москва, ул. Ленина, д. 5", 785690, 4577788, "Иван Долгов"),
                                                new Friend("Обломов", "г. Санкт-Петербург, ул. Семеновская, д.56, кв.456 ", 676050, new DateTime(1982, 8, 9)),
                                                new Friend("Козлов", "г. Москва, ул. Заречная, д.2, кв.34 ", 676050, new DateTime(1983, 3, 4))
                                            };

            foreach (var s in FindSurname(spravkaDataBase, "ов"))
                s.PrintInfo();

            Console.ReadLine();
        }

        private static IEnumerable<Person> FindSurname(Spravka[] spravkaDataBase, string surnameSubstring)
        {
            foreach (var s in spravkaDataBase)
                if (s is Person)
                    if ((s as Person).Surname.Contains(surnameSubstring))
                        yield return s as Person;
        }
    }

    public abstract class Spravka
    {
        public abstract void PrintInfo();
    }

    public class Person : Spravka
    {
        public string Surname { get; set; }
        public string Adres { get; set; }
        public decimal Telephone { get; set; }

        public Person(string surname, string adres, decimal telephone)
        {
            Surname = surname;
            Adres = adres;
            Telephone = telephone;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Фамилия: {0}", Surname);
            Console.WriteLine("Адрес: {0}", Adres);
            Console.WriteLine("Телефон: {0}", Telephone);
        }
    }

    public class Organization : Spravka
    {
        public string Name { get; set; }
        public string AdresOrg { get; set; }
        public int Number { get; set; }
        public int Faks { get; set; }
        public string Kontakt { get; set; }



        public Organization(string name, string adresOrg, int number, int faks, string kontakt)
        {
            Name = name;
            AdresOrg = adresOrg;
            Number = number;
            Faks = faks;
            Kontakt = kontakt;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Название организации: {0}", Name);
            Console.WriteLine("Адрес: {0}", AdresOrg);
            Console.WriteLine("Номер телефона: {0}", Number);
            Console.WriteLine("Факс: {0}", Faks);
            Console.WriteLine("Контактное лицо: {0}", Kontakt);
        }
    }

    public class Friend : Person
    {
        public DateTime BirthdayDate { get; set; }

        public Friend(string surname, string adres, int telephone, DateTime birthdayDate) : base(surname, adres, telephone)
        {
            BirthdayDate = birthdayDate;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Дата рождения: {0}", BirthdayDate);
        }
    }



}


