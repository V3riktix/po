using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Lab01
{
    public class Garage
    {
        private Car[] _cars;
        private string _address;
        private int _carsCount = 0;
        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            set { 
                _capacity = value;
                _cars = new Car[_capacity];
            }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public Garage()
        {
            Address = "Nieznany";
            _cars = null;
            Capacity = 0;
        }
        public Garage(string address, int capacity)
        {
            Address = address;
            Capacity = capacity;
        }
        public void CarIn(Car car)
        {
            if(_carsCount == _capacity)
            {
                Console.WriteLine("Garaż pełny");
            }
            else
            {
                _carsCount++;
                _cars[_carsCount - 1] = car;
            }

        }
        public Car CarOut() {
            if(_carsCount == 0)
            {
                Console.WriteLine("Garaż Pusty");
                return null;
            }
            else
            {
                _carsCount--;
                return _cars[_carsCount];
            }
        }
        public override string ToString()
        {
            string s = $"Garage | Address: {_address}, Capacity: {_capacity}\n";
            foreach(Car car in _cars)
            {
                
                s += $"\t{car.ToString()}\n";
            }
            return s;
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
