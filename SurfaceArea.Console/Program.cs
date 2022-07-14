using SurfaceAreaLib;

var circle = new Circle(8);
var triangle = new Triangle(8,7,8.5);

Console.WriteLine($"Circle surface area: {Helpers.CalcSurfaceArea(circle)}");
Console.WriteLine($"Triangle surface area: {Helpers.CalcSurfaceArea(triangle)}");