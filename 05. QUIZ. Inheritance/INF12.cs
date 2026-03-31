using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class INF12
    {
        public static void Test(IVehicle vehicle)
        {
            vehicle.Start();
            vehicle.Turn();
            vehicle.Stop();
        }

        public interface IVehicle
        {
            void Start();
            void Turn();
            void Stop();
        }

        public class Car : IVehicle
        {
            void IVehicle.Start() => Console.Write(" IVehicle.Start(Car). ");
            public virtual void Turn() => Console.Write(" Car.Turn. ");
            public void Stop() => Console.Write(" Car.Stop. ");
        }

        public class SuperCar : Car
        {
            public override void Turn() => Console.Write(" SuperCar.Turn. ");
        }

        public class ExoticCar : Car
        {
            public override void Turn() => Console.Write(" ExoticCar.Turn. ");
        }

        public class SportCar : SuperCar, IVehicle
        {
            void IVehicle.Start() => Console.Write(" IVehicle.Start(SportCar). ");
            public new void Turn() => Console.Write(" SportCar.Turn. ");
            public new void Stop() => Console.Write(" SportCar.Stop. ");
        }

    }
}
