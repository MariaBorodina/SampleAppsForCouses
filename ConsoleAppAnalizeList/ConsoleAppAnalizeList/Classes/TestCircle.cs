using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnalizeList
{
    class TestCircle : TestSmthBase
    {
        public sealed class Circle
        {
            private double radius;

            public double Calculate(Func<double, double> op)
            {
                return op(radius);
            }
        }

        private double CalculateCircleLen(double radius)
        {
            return Math.PI * radius * 2;
        }

        internal double TestCircleExercise(double radius)
        {
            Log(System.Reflection.MethodInfo.GetCurrentMethod().Name);

            var circle = new Circle();
            var res = circle.Calculate(r => 2 * Math.PI * r); // circle.Calculate(CalculateCircleLen);

            // the problem with the exercise is that 'Circle.radius' is never assigned to, and will always have its default value 0 


            Log(res);
            return res;
        }

    }

}
