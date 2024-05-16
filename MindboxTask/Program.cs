using ShapesLibrary;

Circle circle = new Circle("Круг",6);
Triangle triangle = new Triangle("Треугольник", 3, 3, 5);

Console.WriteLine(circle.CalcSquare());
Console.WriteLine(triangle.CalcSquare());