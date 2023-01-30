/*
 Первое задание:
 Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь:
    - круга по радиусу
    - треугольника по трем сторонам

 Будет хорошо, если будет:
 1. Юнит-тесты (+) [Лежат в проекте ShapeLib.Tests]
 2. Лёгкость добавления других фигур (+) [В проекте ShapeLib.Core добавить класс фигуры в папку Shapes и унаследовать BaseShapeClass, 
    реализовать метод GetArea, по желанию добавить статический метод в высокоуровневый класс Shape]
 3. Вычисление площади фигуры без знания типа фигуры в compile-time [а это разве возможно?]
 4. Проверку на то, является ли треугольник прямоугольным (+) [Свойство IsRight в классе TriangleShape]

 Второе задание:
 В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
 Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
 По возможности — положите ответ рядом с кодом из первого вопроса. 

 SQL запрос лежит в файле GetProductsQuery.txt в этом же проекте

 Заполнение базы дефолтными данными происходит в ProductsDbContext, там же настраивается конекшн стринга
 Миграция накатывается автоматически при запуске ShapeLib.Console

 */

using Microsoft.EntityFrameworkCore;
using ShapeLib.Console;
using ShapeLib.Core.Shapes;
using ShapeLib.Core.Shapes.Common;

var productsDbContext = new ProductsDbContext();
productsDbContext.Database.Migrate();
productsDbContext.SeedDefaultData();

var circleAreaFirst = new CircleShape(5).GetArea(); 
var circleAreaSecond = Shape.Circle.GetArea(5);

var triangleAreaFirst = new TriangleShape(3, 4, 5).GetArea();
var triangleAreaSecond = Shape.Triangle.GetArea(3, 4, 5);

var triangleIsRightFirst = new TriangleShape(3, 4, 5).IsRight;
var triangleIsRightSecond = Shape.Triangle.IsRight(3, 4, 5);


Console.WriteLine($"Circle GetArea Low Level Method: {circleAreaFirst}");
Console.WriteLine($"Circle GetArea High Level Method: {circleAreaSecond}");

Console.WriteLine($"Triangle GetArea Low Level Method: {triangleAreaFirst}");
Console.WriteLine($"Triangle GetArea High Level Method: {triangleAreaSecond}");

Console.WriteLine($"Triangle IsRight Low Level Method: {triangleIsRightFirst}");
Console.WriteLine($"Triangle IsRight High Level Method: {triangleIsRightSecond}");
