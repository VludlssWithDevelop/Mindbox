using ShapeLib.Core.Shapes.Common;

namespace ShapeLib.Core.Shapes
{
    /// <summary>
    /// Фигура: Треугольник
    /// </summary>
    public sealed class TriangleShape : BaseShapeClass
    {
        /// <summary>
        /// Катет 1
        /// </summary>
        private readonly double _a;
        /// <summary>
        /// Катет 2
        /// </summary>
        private readonly double _b;
        /// <summary>
        /// Гипотенуза
        /// </summary>
        private readonly double _c;
        /// <summary>
        /// Треугольник прямоугольный?
        /// </summary>
        private readonly bool _isRight;

        /// <summary>
        /// Треугольник прямоугольный?
        /// </summary>
        public bool IsRight => _isRight;

        /// <param name="a">Катет 1</param>
        /// <param name="b">Катет 2</param>
        /// <param name="c">Гипотенуза</param>
        public TriangleShape(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;

            _isRight = Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }

        public override double GetArea()
        {
            double p = (_a + _b + _c) / 2;
            double preResult = p * (p - _a) * (p - _b) * (p - _c);

            double triangleArea = Math.Sqrt(preResult);
            return triangleArea;
        }
    }
}
