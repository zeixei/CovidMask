using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{

	public class Program
	{
		static void Main(string[] args)
		{

            Person person1 = new Person();
            person1.FirstName = "z";
            person1.LastName = "g";
            person1.DateOfBirthYear = 1980;
            person1.NationalIdentity = 1;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
	}
}

