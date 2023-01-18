namespace VectorsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Mapper vectorMapper = new Mapper("vectors");
            Mapper triangleMapper = new Mapper("triangles");
            
            //создаём треугольник содержащий вектора 1 и 5
            Triangle t = new Triangle(new List<string> { "0", "1", "5" });

            //обращаемся к первому
            double x1 = t.v1._x;
            Console.WriteLine(x1);

            //и ещё раз к первому
            double y1 = t.v1._y;
            Console.WriteLine();

            //ко второму
            double x2 = t.v2._x;

            Console.WriteLine();
            //меняем первый вектор
            t.v1_id = 4;
            double x3 = t.v1._x;
            Console.WriteLine(x3);
        }
    }
}