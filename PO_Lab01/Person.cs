using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Lab01
{
    public class Person
    {
        private string[] _registarionNumbers = new string[3];
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _carsCount;
        private static int _maxCarCount = 3;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public int CarsCount
        {
            get { return _carsCount; }
            set {
                if (value > MaxCarCount)
                {
                    _carsCount = MaxCarCount;
                }
                else
                {
                    _carsCount = value;
                }
            }
        }
        public static int MaxCarCount
        {
            get { return _maxCarCount; }
        }

        public Person()
        {
            _registarionNumbers = null;
            _firstName = "Nieznane";
            _lastName = "Nieznane";
            _address = "Nieznany";
            _carsCount = 0;
        }
        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            _registarionNumbers = null;
            _carsCount = 0;
        }
        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            CarsCount = cars.Length;
            for(int i = 0; i < CarsCount; ++i) {
                _registarionNumbers[i] = cars[i].RegistrationNumber;
            }
        }
        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if (CarsCount == MaxCarCount) {
                Console.WriteLine("Nie można dodać więcej aut");
            }
            else
            {
                _registarionNumbers[CarsCount] = registrationNumber;
                CarsCount++;
            }
        }
        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            if(CarsCount == 0)
            {
                Console.WriteLine("Nie można usunąć aut: brak pojazdów");
            }
            else
            {
                CarsCount--;
            }
        }
        public override string ToString()
        {
            string s = $"Person | Name: {FirstName}, LastName: {LastName}, Address: {Address}\n Registration Numbers: ";
            for(int i = 0; i < CarsCount; ++i)
            {
                s += $"{_registarionNumbers[i]}";
            }
            return s;
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
