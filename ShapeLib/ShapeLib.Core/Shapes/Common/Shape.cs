namespace ShapeLib.Core.Shapes.Common
{
    /// <summary>
    /// Фигура. Высокоуровневые методы для работы с фигурами.
    /// </summary>
    public static class Shape
    {
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <param name="anyShape">Любой наследник базового класса фигуры, реализовавший метод GetArea</param>
        /// <returns>Площадь фигуры</returns>
        public static double GetArea(BaseShapeClass anyShape)
            => anyShape.GetArea();

        /// <summary>
        /// Фигура: Круг
        /// </summary>
        public static class Circle
        {
            /// <summary>
            /// Получить площадь круга
            /// </summary>
            /// <param name="radius">Радиус</param>
            /// <returns>Площадь круга</returns>
            public static double GetArea(double radius)
                => new CircleShape(radius).GetArea();
        }

        /// <summary>
        /// Фигура: Треугольник
        /// </summary>
        public static class Triangle
        {
            /// <summary>
            /// Треугольник прямоугольный?
            /// </summary>
            /// <param name="a">Катет 1</param>
            /// <param name="b">Катет 2</param>
            /// <param name="c">Гипотенуза</param>
            /// <returns>Треугольник прямоугольный?</returns>
            public static bool IsRight(double a, double b, double c)
                => new TriangleShape(a, b, c).IsRight;

            /// <summary>
            /// Получить площадь треугольника
            /// </summary>
            /// <param name="a">Катет 1</param>
            /// <param name="b">Катет 2</param>
            /// <param name="c">Гипотенуза</param>
            /// <returns>Площадь треугольника</returns>
            public static double GetArea(double a, double b, double c)
                => new TriangleShape(a, b, c).GetArea();
        }
    }
}