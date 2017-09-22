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
        private double wingSpan;
        private double takeOffWeight;

        public AirPlane() : base()
        {
            wingSpan = 0;
            takeOffWeight = 0;
        }

        public AirPlane (int speed, string manufactor, double width, double height, Engine engine, int amount, double wingSpan, double takeOffWeight): base(speed, manufactor, width, height, engine, amount)
        {
            this.wingSpan = wingSpan;
            this.takeOffWeight = takeOffWeight;
        }

        public double WingSpan
        {
            get { return wingSpan; }
            set { wingSpan = value; }
        }

        public double TakeOffWeight
        {
            get { return takeOffWeight; }
            set { takeOffWeight = value; }
        }
    }

    public class Ship : WaterTransport
    {
        private double displacement;
        private string navigationArea;

        public Ship(): base()
        {
            displacement = 0;
            navigationArea = "unknown";
        }

        public Ship (int speed, string manufactor, double width, double height, Engine engine, int amount, double displacement, string navigationArea) : base(speed, manufactor, width, height, engine, amount)
        {
            this.displacement = displacement;
            this.navigationArea = navigationArea;
        }

        public double Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public string NavigationArea
        {
            get { return navigationArea; }
            set { navigationArea = value; }
        }
    }

    public class Train : LandTransport
    {
        //  подвижность состава
        private string rollingStock;
        //  регулярность обращения: круглогодичный, летний, разовый
        private string regular;

        public Train() : base()
        {
            rollingStock = "unknown";
            regular = "unknown";
        }

        public Train(int speed, string manufactor, double width, double height, Engine engine, int amount, string rollingStock, string regular) : base(speed, manufactor, width, height, engine, amount)
        {
            this.rollingStock = rollingStock;
            this.regular = regular;
        }

        public string RollingStock
        {
            get { return rollingStock; }
            set { rollingStock = value; }
        }

        public string Regular
        {
            get { return regular; }
            set { regular = value; }
        }
    }

    public class Bike : LandTransport
    {
        private string model;
        private string brakes;

        public Bike() : base()
        {
            model = "unknown";
            brakes = "unknown";
        }

        public Bike(int speed, string manufactor, double width, double height, Engine engine, int amount, string model, string brakes) : base(speed, manufactor, width, height, engine, amount)
        {
            this.model = model;
            this.brakes = brakes;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Brakes
        {
            get { return brakes; }
            set { brakes = value; }
        }
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
        private string blendingProcess; //  injector, carburetor
        
        public PetrolEngine() : base()
        {
            blendingProcess = "unknown";
        }

        public PetrolEngine(int power, string manufactor, string blendingProcess) : base(power, manufactor)
        {
            this.blendingProcess = blendingProcess;
        }

        public string BlendingProcess
        {
            get { return blendingProcess; }
            set { blendingProcess = value; }
        }
    }

    public class Disel : Engine
    {
        private string construction;

        public Disel () : base()
        {
            construction = "unknown";
        }

        public Disel(int power, string manufactor, string construction) : base(power, manufactor)
        {
            this.construction = construction;
        }

        public string Construction
        {
            get { return construction; }
            set { construction = value; }
        }
    }

    public class ReactiveEngine : Engine
    {
        private string classes;

        public ReactiveEngine() : base()
        {
            classes = "unknown";
        }

        public ReactiveEngine(int power, string manufactor, string classes) : base(power, manufactor)
        {
            this.classes = classes;
        }

        public string Classes
        {
            get { return classes; }
            set { classes = value; }
        }
    }
}