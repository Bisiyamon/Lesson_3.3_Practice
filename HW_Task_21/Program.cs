// Найти расстояние между точками в пространстве

double[] pointA = new double[3];
double[] pointB = new double[3];

void InputCoordinates(double[] coordinates)
{
    for(int index = 0; index<3; index++)
    {
        switch(index)
        {
        case 0:
            Console.Write("Input value X: ");
            coordinates[0] = Convert.ToDouble(Console.ReadLine());
            break;
        case 1:
            Console.Write("Input value Y: ");
            coordinates[1] = Convert.ToDouble(Console.ReadLine());
            break;
        case 2:
            Console.Write("Input value Z: ");
            coordinates[2] = Convert.ToDouble(Console.ReadLine());
            break;
        }
    }
}

void ShowCoordinates(double[] coordinates)
{
    System.Console.Write("( ");
    for(int index = 0; index<3; index++)
    {
        Console.Write(coordinates[index]);
        Console.Write("; ");
    }
    System.Console.WriteLine(")");
}

void CalculationDistance(double[] array1, double[] array2)
{
    double calcdist = 0;
    for(int index = 0; index<3; index++)
    {
        calcdist = calcdist + Math.Pow(array2[index] - array1[index], 2);    
    }
    calcdist = Math.Sqrt(calcdist);
    System.Console.Write("Disttance between first & second points: ");
    Console.WriteLine(calcdist);
}

System.Console.WriteLine();
Console.WriteLine("Please enter coordinates first point: ");
InputCoordinates(pointA);
Console.WriteLine("Please enter coordinates second point: ");
InputCoordinates(pointB);
ShowCoordinates(pointA);
ShowCoordinates(pointB);
CalculationDistance(pointA, pointB);
System.Console.WriteLine();
