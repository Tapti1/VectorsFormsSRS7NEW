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

            Vector v1 = (Vector)vectorMapper.GetById(1);
            Vector v2 = (Vector)vectorMapper.GetById(3);
            Console.WriteLine();

            //создаём его ещё раз
            Vector v3 = (Vector)vectorMapper.GetById(1);
            Console.WriteLine();

            //создаём треугольник содержащий вектора 1 и 3
            Triangle t = new Triangle(new List<string> { "0", "1", "5" });
        }
    }
}