using global::System.Numerics;

namespace Interfaces
{
    public interface ITriangle
    {
        double CalculateAreaBySides(double sideA, double sideB, double sideC);
        double CalculateAreaByAngle(double sideBase, double height, double angle);
        double CalculateArea(double sideBase, double height);
    }
}
