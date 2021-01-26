using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder
{
    class HeavyCar : CarBuilder
    {
        public override void AddBox()
        {
            Do.coffee = new Box() { Name = "Arabaica" };
        }

        public override void AddWheels()
        {
            Do.milk = new Wheels() { Name = "some milk with foam" };
        }

        public override void AddMotor()
        {
            Do.sugar = new Motor() { Name = "some sugar for capuchino" };
        }

        public override void AddBody()
        {
            Do.water = new Body() { Name = "some water for capuchino" };
        }
    }
    
    class Mechanik
    {
        public CarRice Make(CarBuilder coffeeBuilder)
        {
            coffeeBuilder.AddBox();
            coffeeBuilder.AddWheels();
            coffeeBuilder.AddMotor();
            coffeeBuilder.AddBody();
        }
    }
    abstract class CarBuilder
    {
        public abstract void AddBox();
        public abstract void AddWheels();
        public abstract void AddMotor();
        public abstract void AddBody();

    }
    class CarRice
    {
        public Box box { get; set; }
        public Wheels wheels { get; set; }
        public Motor motor { get; set; }
        public Body body { get; set; }
        public override string ToString()
        {
            string result = box.Name + Environment.NewLine +
                wheels.Name + Environment.NewLine +
                motor.Name + Environment.NewLine +
                body.Name + Environment.NewLine;
            return result;
        }
    }
    class Box
    {
        public string Name { get; set; }
    }
    class Wheels
    {
        public string Name { get; set; }
    }

    class Motor
    {
        public string Name { get; set; }
    }

    class Body
    {
        public string Name { get; set; }
    }
}
