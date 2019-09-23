using System;
namespace Equation
{
    public class Equation
    {
        public double Left { get; set; }
        public double Right { get; set; }

        public Equation()
        {
            Left = 0;
            Right = 0;
        }

        public Equation(double left, double right)
        {
            left = Left;
            right = Right;
        }

        public double Add()
        {
            double add;
            add = Left + Right;
            return add;
        }

        public double Subtract()
        {
            double subtract;
            subtract = Left - Right;
            return subtract;
        }

        public double Multiply()
        {
            double multiply;
            multiply = Left * Right;
            return multiply;
        }

        public double LeftToThePower(int power)
        {
            power = (int)Right;
            double leftPower = Math.Pow(Left, power);
            return leftPower;
        }

        public double RightToThePower(int power)
        {
            power = (int)Left;
            double rightPower = Math.Pow(Right, power);
            return rightPower;
        }
    }
}
