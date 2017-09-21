using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Transport
    {
        protected int speed;
        protected string manufactor;
        protected double width;
        protected double height;
        protected Engine engine;
        protected int amount;

        public Transport()
        {
            manufactor = "unknown";
        }

        public Transport(int speed, string manufactor, double width, double height, Engine engine, int amount)
        {
            this.speed = speed;
            this.manufactor = manufactor;
            this.width = width;
            this.height = height;
            this.engine = engine;
            this.amount = amount;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string Manufactor
        {
            get { return manufactor; }
            set { manufactor = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string getInformation()
        {
            return "Manufactor: " + manufactor
                  + " , speed: " + speed
                  + ", weight: " + width
                  + ", height: " + height
                  + ", engine: " + engine.getInformation()
                  + ", amount: " + amount;
        }
    }

    public abstract class WaterTransport : Transport
    {
        public WaterTransport() : base()
        {

        }

        public WaterTransport(int speed, string manufactor, double width, double height, Engine engine, int amount) : base(speed, manufactor, width, height, engine, amount)
        {

        }        
       
    }

    public abstract class AirTransport : Transport
    {
        public AirTransport() : base()
        {

        }

        public AirTransport(int speed, string manufactor, double width, double height, Engine engine, int amount) : base(speed, manufactor, width, height, engine, amount)
        {

        }

       
    }

    public abstract class LandTransport : Transport
    {
        public LandTransport() : base()
        {

        }

        public LandTransport(int speed, string manufactor, double width, double height, Engine engine, int amount) : base(speed, manufactor, width, height, engine, amount)
        {

        }        
       
    }

    public class Car : LandTransport
    {
        private string transmission;
        private string body;

        public Car() : base()
        {
            transmission = "unknown";
            body = "unknown";
        }

        public Car(int speed, string manufactor, double width, double height, Engine engine, int amount, string transmission, string body) 
                : base(speed, manufactor, width, height, engine, amount)
        {
            this.transmission = transmission;
            this.body = body;
        }

        public string Transmisson
        {
            get { return transmission; }
            set { transmission = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }
    }

    public class AirPlane : AirTransport
    {

    }

    public class Ship : WaterTransport
    {

    }

    public class Train : LandTransport
    {

    }

    public class Bike : LandTransport
    {

    }

    public abstract class Engine
    {
        protected int power;
        protected string manufactor;

        public Engine()
        {
            manufactor = "unknown";
        }

        public Engine(int power, string manufactor)
        {
            this.power = power;
            this.manufactor = manufactor;
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Manufactor
        {
            get { return manufactor; }
            set { manufactor = value; }
        }

        public string getInformation()
        {
            return "Power: " + power
                + ", manufactor: " + manufactor;
        }
    }

    public class PetrolEngine : Engine
    {

    }

    public class Disel : Engine
    {

    }

    public class ReactiveEngine : Engine
    {

    }
}