using ShapeLib.Core.Shapes.Common;

namespace ShapeLib.Core.Shapes
{
    /// <summary>
    /// Фигура: Круг
    /// </summary>
    public sealed class CircleShape : BaseShapeClass
    {
        private readonly double _radius;

        public CircleShape(double radius)
        {
            _radius = radius;
        }

        public override double GetArea() 
            => Math.PI * Math.Pow(_radius, 2);
    }
}
