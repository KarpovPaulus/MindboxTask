using ShapesLibrary;

Circle circle = new Circle("Круг",4);
Triangle triangle = new Triangle("Треугольник", 3, 4, 5);

Console.WriteLine(circle.CalcSquare());
Console.WriteLine(triangle.CalcSquare());