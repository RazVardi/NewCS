using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SurfaceCalculate
{
    class Program : Surface
    {
        static void Main(string[] args)
        {
            String choose = "", resSurface = "", shapesOptions0 = "0 for circle", shapesOptions1 = "1 for ellipse", shapesOptions2 = "2 for square",
                shapesOptions3 = "3 for rectangle", shapesOptions4 = "4 for triangular", shapesOptions5 = "5 for rightAngledTriangle",
                shapesOptions6 = "6 for rhombus", shapesOptions7 = "7 for trapezoidRightAngle", shapesOptions8 = "8 for equilibriumTrapezoid",
                shapesOptions9 = "9 for parallelogram",shapeOptionMinus1="-1 for pentagon", shapeOptionMinus2 = "-2 for hexagon",
                shapeOptionMinus3 = "-3 for heptagon", shapeOptionMinus4 = "-4 for octagon", shapeOptionMinus5 = "-5 for nonagon",
                shapeOptionMinus6 = "-6 for decagon"; 
            Surface surface = new Surface();
            Console.WriteLine("plese choose a shape from list beloew: ");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}\n{10}\n{11}\n{12}\n{13}\n{14}\n{15}",
                shapesOptions0, shapesOptions1, shapesOptions2,shapesOptions3, shapesOptions4, shapesOptions5,
                shapesOptions6, shapesOptions7, shapesOptions8, shapesOptions9,shapeOptionMinus1,shapeOptionMinus2,
                shapeOptionMinus3,shapeOptionMinus4,shapeOptionMinus5,shapeOptionMinus6);
            choose = Console.ReadLine();
            surface.Shape = choose;
            resSurface = surface.SurfaceCalculate.ToString();
            Console.WriteLine("the resulft of surface of  {0} , {1}", choose,resSurface );
            Thread.Sleep(10000);
        }
       
    }

    class Surface
    {
        private string shape = null;
        //ArraySegment<Array> arrays =new ArraySegment<Array>();
        private double side1 = 0, side2 = 0, side3 = 0, radius = 0,radius2=0, angleSide3 = 0, angleSide2 = 0, angleBaseDown = 0, 
            surfaceRes = 0,triangleHeight=0, diagonal1=0, diagonal2=0,trapezeHeight=0,baseUp=0,baseDown=0, parallelogramHeight=0,
            apotheum=0, shortSide=0;
        private  readonly double PI=Math.PI;
        public string Shape
        {
            get
            {
                return shape;
            }
            set
            {
                shape = value;
            }
        }

        public double SurfaceCalculate
        {

            get
            {

                if (shape == "0")//shape="circle"
                {
                    Console.WriteLine("please enter radius");
                    radius = double.Parse(Console.ReadLine());
                    surfaceRes = (radius * radius * PI) / 4;
                    return surfaceRes;

                }
                if (shape == "1")//shape="ellipse"
                {
                    Console.WriteLine("please enter radius");
                    radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter 2 radius");
                    radius2 = double.Parse(Console.ReadLine());
                    surfaceRes = radius * radius2 * PI;
                    return surfaceRes;
                }

                ///all the is side equal and all angle is 90 degrees
                if (shape == "2")//shape="square"
                {
                    Console.WriteLine("please enter side1");
                    side1 = double.Parse(Console.ReadLine());
                    surfaceRes = side1 * side1;
                    return surfaceRes;
                }

                //all angle is 90 degrees
                if (shape == "3")//shape="rectangle"
                {
                    Console.WriteLine("please enter side1");
                    side1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter side2");
                    side2 = double.Parse(Console.ReadLine());
                    surfaceRes = side1 * side2;
                    return surfaceRes;
                }

                //side1 is base of the triangle
                if (shape == "4")//shape="triangular"
                {
                    Console.WriteLine("please enter side1");
                    side1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter side2");
                    side2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter angleSide3");
                    angleSide3 = double.Parse(Console.ReadLine());
                    triangleHeight = side2 * (Math.Tanh(angleSide3));//angle 3 is facing side 3 and angle 2 is facing side 2
                    Console.WriteLine(triangleHeight);
                    surfaceRes = (side1 * triangleHeight) / 2;
                    return surfaceRes;
                }
                if (shape == "5")//shape="rightAngledTriangle"
                {
                    Console.WriteLine("please enter side1");
                    side1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter side2");
                    side2 = double.Parse(Console.ReadLine());
                    surfaceRes = (side1 * side2) / 2;
                    return surfaceRes;
                }

                //all the is side equal and diagonal is halfing each other but not equal each other.    
                if (shape == "6") //shape="rhombus"
                {
                    Console.WriteLine("please enter side1");
                    side1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter angleSide2");
                    angleSide2 = double.Parse(Console.ReadLine());
                    diagonal1 = 2 * side1 * Math.Cos(angleSide2);
                    diagonal2 = 2 * side1 * Math.Sin(angleSide2);
                    surfaceRes = diagonal1 * diagonal2;
                    return surfaceRes;
                }

                if (shape == "7")//shape="trapezoidRightAngle"
                {
                    Console.WriteLine("please enter angleBaseDown");
                    angleBaseDown = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter baseDown");
                    baseDown = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter baseUp");
                    baseUp = double.Parse(Console.ReadLine());
                    trapezeHeight = baseUp * Math.Tanh(angleBaseDown);
                    Console.WriteLine(trapezeHeight);
                    surfaceRes = ((baseUp + baseDown) / 2 * trapezeHeight) - (trapezeHeight * baseUp / 2);
                    return surfaceRes;
                }

                if (shape == "8")//shape="equilibriumTrapezoid"
                {
                    Console.WriteLine("please enter angleBaseDown");
                    angleBaseDown = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter baseDown");
                    baseDown = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter baseUp");
                    baseUp = double.Parse(Console.ReadLine());
                    trapezeHeight = baseUp * Math.Tanh(angleBaseDown);
                    surfaceRes = ((baseUp + baseDown) / 2) * trapezeHeight;
                    return surfaceRes;
                }

                if (shape == "9")//shape="parallelogram"
                {
                    Console.WriteLine("please enter baseDown");
                    baseDown = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter angleBaseDown");
                    angleBaseDown = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter shortSide");
                    shortSide = double.Parse(Console.ReadLine());
                    parallelogramHeight = shortSide * Math.Sin(angleBaseDown);
                    surfaceRes = baseDown * parallelogramHeight;
                    return surfaceRes;
                }
                if (shape == "-1")//shape="pentagon"
                {
                    Console.WriteLine("please enter side3");
                    side3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter apothem(radius of pentagon)");
                    apotheum = double.Parse(Console.ReadLine());
                    surfaceRes = (5.0 / 2.0) * side3 * apotheum;
                    return surfaceRes;
                }
                if (shape == "-2")//shape="hexagon"
                {
                    Console.WriteLine("please enter side3");
                    side3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter apothem(radius of pentagon)");
                    apotheum = double.Parse(Console.ReadLine());
                    surfaceRes = (6.0 / 2.0) * side3 * apotheum;
                    return surfaceRes;
                }
                if (shape == "-3")//shape="heptagon"
                {
                    Console.WriteLine("please enter side3");
                    side3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter apothem(radius of pentagon)");
                    apotheum = double.Parse(Console.ReadLine());
                    surfaceRes = (7.0 / 2.0) * side3 * apotheum;
                    return surfaceRes;
                }
                if (shape == "-4")//shape="octagon"
                {
                    Console.WriteLine("please enter side3");
                    side3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter apothem(radius of pentagon)");
                    apotheum = double.Parse(Console.ReadLine());
                    surfaceRes = (8.0 / 2.0) * side3 * apotheum;
                    return surfaceRes;
                }
                if (shape == "-5")//shape="nonagon"
                {
                    Console.WriteLine("please enter side3");
                    side3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter apothem(radius of pentagon)");
                    apotheum = double.Parse(Console.ReadLine());
                    surfaceRes = (9.0 / 2.0) * side3 * apotheum;
                    return surfaceRes;
                }
                if (shape == "-6")//shape="decagon"
                {
                    Console.WriteLine("please enter side3");
                    side3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("please enter apothem(radius of pentagon)");
                    apotheum = double.Parse(Console.ReadLine());
                    surfaceRes = (10.0 / 2.0) * side3 * apotheum;
                    return surfaceRes;
                }
                String errorMessage = "no valid optio, please choose from -6 include to 9";
                Console.WriteLine(errorMessage);
                return double.Parse(errorMessage);
            }
            set{}
        }
    }

}
