using System;
using System.Collections.Generic;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string surname = "Aliyev";

            var akif = new Person();
            akif.Id = 1;
            akif.Name = "Akif";
            akif.Surname = surname;
            akif.DateOfBirth = DateTime.Now.AddYears(-100);
            akif.ParentPerson = null;

            var semed = new Person();
            semed.Id = 2;
            semed.Name = "Semed";
            semed.Surname = surname;
            semed.DateOfBirth = DateTime.Now.AddYears(-80);
            semed.ParentPerson = akif;

            var terlan = new Person();
            terlan.Id = 3;
            terlan.Name = "Terlan";
            terlan.Surname = surname;
            terlan.DateOfBirth = DateTime.Now.AddYears(-82);
            terlan.ParentPerson = akif;

            var namiq = new Person();
            namiq.Id = 4;
            namiq.Name = "Namiq";
            namiq.Surname = surname;
            namiq.DateOfBirth = DateTime.Now.AddYears(-60);
            namiq.ParentPerson = semed;

            var huseyn = new Person();
            huseyn.Id = 5;
            huseyn.Name = "Huseyn";
            huseyn.Surname = surname;
            huseyn.DateOfBirth = DateTime.Now.AddYears(-40);
            huseyn.ParentPerson = namiq;

            var cemil = new Person();
            cemil.Id = 6;
            cemil.Name = "Cemil";
            cemil.Surname = surname;
            cemil.DateOfBirth = DateTime.Now.AddYears(-42);
            cemil.ParentPerson = namiq;

            var vaqif = new Person();
            vaqif.Id = 7;
            vaqif.Name = "Vaqif";
            vaqif.Surname = surname;
            vaqif.DateOfBirth = DateTime.Now.AddYears(-63);
            vaqif.ParentPerson = semed;

            var ramil = new Person();
            ramil.Id = 8;
            ramil.Name = "Ramil";
            ramil.Surname = surname;
            ramil.DateOfBirth = DateTime.Now.AddYears(-64);
            ramil.ParentPerson = terlan;

            var tural = new Person();
            tural.Id = 9;
            tural.Name = "Tural";
            tural.Surname = surname;
            tural.DateOfBirth = DateTime.Now.AddYears(-41);
            tural.ParentPerson = vaqif;

            var nizami = new Person();
            nizami.Id = 10;
            nizami.Name = "Nizami";
            nizami.Surname = surname;
            nizami.DateOfBirth = DateTime.Now.AddYears(-44);
            nizami.ParentPerson = ramil;

            var babek = new Person();
            babek.Id = 11;
            babek.Name = "Babek";
            babek.Surname = surname;
            babek.DateOfBirth = DateTime.Now.AddYears(-45);
            babek.ParentPerson = ramil;

            var cefer = new Person();
            cefer.Id = 12;
            cefer.Name = "Cefer";
            cefer.Surname = surname;
            cefer.DateOfBirth = DateTime.Now.AddYears(-20);
            cefer.ParentPerson = huseyn;

            var nadir = new Person();
            nadir.Id = 13;
            nadir.Name = "Nadir";
            nadir.Surname = surname;
            nadir.DateOfBirth = DateTime.Now.AddYears(-21);
            nadir.ParentPerson = cemil;

            var ibrahim = new Person();
            ibrahim.Id = 14;
            ibrahim.Name = "Ibrahim";
            ibrahim.Surname = surname;
            ibrahim.DateOfBirth = DateTime.Now.AddYears(-22);
            ibrahim.ParentPerson = babek;

            var vuqar = new Person();
            vuqar.Id = 15;
            vuqar.Name = "Vuqar";
            vuqar.Surname = surname;
            vuqar.DateOfBirth = DateTime.Now.AddYears(-24);
            vuqar.ParentPerson = babek;

            akif.ChildPerson = new List<Person>()
            {
                semed,
                terlan
            };

            semed.ChildPerson = new List<Person>()
            {
                namiq,
                vaqif
            };

            terlan.ChildPerson = new List<Person>()
            {
                ramil
            };

            namiq.ChildPerson = new List<Person>()
            {
                huseyn,
                cemil
            };

            vaqif.ChildPerson = new List<Person>()
            {
                tural
            };

            ramil.ChildPerson = new List<Person>()
            {
                nizami,
                babek
            };

            huseyn.ChildPerson = new List<Person>()
            {
                cefer
            };

            cemil.ChildPerson = new List<Person>()
            {
                nadir
            };

            babek.ChildPerson = new List<Person>()
            {
                ibrahim,
                vuqar
            };

            List<Person> personList = new List<Person>();
            personList.Add(akif);
            personList.Add(semed);
            personList.Add(terlan);
            personList.Add(namiq);
            personList.Add(vaqif);
            personList.Add(ramil);
            personList.Add(huseyn);
            personList.Add(cemil);
            personList.Add(tural);
            personList.Add(nizami);
            personList.Add(babek);
            personList.Add(cefer);
            personList.Add(nadir);
            personList.Add(ibrahim);
            personList.Add(vuqar);

            //Find grandparent of person
            Console.Write("Enter person id for to find this person's grandfather : ");
            int number = int.Parse(Console.ReadLine());

            foreach (var person in personList)
            {
                if (number == person.Id)
                {
                    if ((person.ParentPerson != null) && (person.ParentPerson.ParentPerson != null))
                    {
                        Console.WriteLine("The grandparent of {0} is {1}", person.Name, person.ParentPerson.ParentPerson.Name);
                    }
                    else
                    {
                        Console.WriteLine("Grandparent is not found.");
                        break;
                    }
                }
            }

            Console.ReadLine();

            //Find 4th generation of childs of person
            Console.Write("Enter person id for to find 4th generation of childs of person : ");
            int number2 = int.Parse(Console.ReadLine());

            foreach (var person in personList)
            {
                if (number2 == person.Id)
                {
                    if (person.ChildPerson.Count != 0)
                    {
                        foreach (var child in person.ChildPerson)
                        {
                            if (child.ChildPerson.Count != 0)
                            {
                                foreach (var secondGenChild in child.ChildPerson)
                                {
                                    if (secondGenChild.ChildPerson.Count != 0)
                                    {
                                        foreach (var thirthGenChild in secondGenChild.ChildPerson)
                                        {
                                            Console.WriteLine($"The 4th generation of childs of {person.Name} Id is {thirthGenChild.Name}");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }

        static void AddPersonToList(Person person)
        {
            List<Person> personList = new List<Person>();
            personList.Add(person);
        }
    }
}
