using System;
using Exceptions;
using Interfaces;

/*
 Note: Formula is referred from http://www.calculator.net/triangle-calculator.html
                                http://www.wikihow.com/Determine-if-Three-Side-Lengths-Are-a-Triangle
*/
public class Triangle : ITriangle
{
    /// <summary>
    /// Formula :  Area = 0.5*x*y sin(c) = 0.5*x*z sin(a) = 0.5*y*z sin(b) 
    /// //convert to radian Formula= Pi/180 *angle
    /// </summary>
    /// <param name="side1"></param>
    /// <param name="side2"></param>
    /// <param name="angle"></param>
    /// <returns></returns>
    public double CalculateAreaByAngle(double side1, double side2, double angle)
    {
        if (side1 < 0 || side2 < 0 || angle < 0)
            throw new InvalidTriangleException("Input should be non negative numbers");

        return 0.5 * side1 * side2 * Math.Sin((Math.PI / 180) * angle);
    }

    /// <summary>
    /// Formula: 0.5*base*height
    /// </summary>
    /// <param name="sideBase"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    public double CalculateArea(double sideBase, double height)
    {
        if (sideBase < 0 || height < 0)
            throw new InvalidTriangleException("Input should be non negative numbers");

        return 0.5 * sideBase * height;
    }

    /// <summary>
    /// Heron's Formula:  Area = (s(s-x)(s-y)(s-z))½
    /// where s = ½(x + y + z) 
    /// </summary>
    /// <param name="sideA"></param>
    /// <param name="sideB"></param>
    /// <param name="sideC"></param>
    /// <returns></returns>
    public double CalculateAreaBySides(double sideA, double sideB, double sideC)
    {
        if (sideA < 0 || sideB < 0 || sideC < 0)
            throw new InvalidTriangleException("Input should be non negative numbers");

        
        if ((sideA + sideB < sideC) || (sideB + sideC < sideA) || (sideA + sideC < sideB))
            throw new InvalidTriangleException("Input cannot form valid Triangle");

        double perimeter = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
    }

}
