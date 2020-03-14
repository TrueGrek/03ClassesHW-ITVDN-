using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Vehicle
    {
        readonly int x;
        readonly int y;
        readonly int cost;
        readonly int speed;
        readonly int year;

        public int X
        {
            get { return this.x; }
        }
        public int Y
        {
            get { return this.y; }
        }
        public int Cost
        {
            get { return this.cost; }
        }
        public int Speed
        {
            get { return this.speed; }

        }
        public int Year
        {
            get { return this.year; }
        }

        public Vehicle(int x, int y, int cost, int speed, int year)
        {
            this.x = x;
            this.y = y;
            this.cost = cost;
            this.speed = speed;
            this.year = year;
        }
        public Vehicle(int cost, int speed, int year)
            : this(0,0,cost,speed,year)
        {
            
        }
    }
    class Car : Vehicle
    {
        public Car(int x, int y, int cost, int speed, int year)
            :base(x, y, cost, speed, year)
        {

        }

        public Car(int cost, int speed, int year)
            : base(0, 0, cost, speed, year)
        {

        }
    }

    class Ship : Vehicle
    {
        private int port;
        private int passengers;

        public int Port
        {
            get { return this.port; }
            set { port = value; }
        }
        public int Passengers
        {
            get { return this.passengers; }
            set { passengers = value; }
        }
        public Ship(int x, int y, int cost, int speed, int year)
            : base(x, y, cost, speed, year)
        {

        }

        public Ship(int cost, int speed, int year)
            : base(0, 0, cost, speed, year)
        {

        }
    }
    class Plane : Vehicle
    {
        private int high;
        private int passengers;

        public int High
        {
            get { return this.high; }
            set { high = value; }
        }
        public int Passengers
        {
            get { return this.passengers; }
            set { passengers = value; }
        }
        public Plane(int x, int y, int cost, int speed, int year)
            : base(x, y, cost, speed, year)
        {

        }

        public Plane(int cost, int speed, int year)
            : base(0, 0, cost, speed, year)
        {

        }
    }
}
