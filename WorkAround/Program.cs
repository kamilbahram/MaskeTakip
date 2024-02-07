// See https://aka.ms/new-console-template for more information
using Business.Conrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

Person person = new Person();
person.NationalIdentity = 32903294866;
person.FirstName = "Kamil";
person.LastName = "Bahram";
person.DateOfBirthYear = 1995;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);
