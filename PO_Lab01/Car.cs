﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Lab01
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private string _registrationNumber;
        private static int _carCount;

        public string Brand
        {
            get { return _brand; } 
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int DoorCount
        {
            get { return _doorCount; }
            set { _doorCount = value; }
        }
        public float EngineVolume
        {
            get { return _engineVolume; }
            set { _engineVolume = value; }
        }
        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }
        public double AvgConsump
        {
            get { return _avgConsump; }
            set { _avgConsump = value; }
        }
        public Car()
        {
            _brand = "Nieznany";
            _model = "Nieznany";
            _doorCount = 0;
            _engineVolume= 0;
            _avgConsump = 0;
            _registrationNumber = "Nieznany";
            _carCount++;
        }
        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _registrationNumber = registrationNumber;
            _carCount++;
        }
        public double CalculateConsump(double roadLength)
        {
            return (AvgConsump * roadLength) / 100.0;
        }
        public double CalculateCost(double roadLength, double pertrolCost) {
            return CalculateConsump(roadLength) * pertrolCost;
        }
        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}, RegistrationNumber: {_registrationNumber}";
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
        public static void DisplayCarCount()
        {
            Console.WriteLine(_carCount);
        }
        public Car Clone()
        {
            return (Car)this.MemberwiseClone();
        }
    }
}
