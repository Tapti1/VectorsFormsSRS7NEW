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
            
            //������ ����������� ���������� ������� 1 � 5
            Triangle t = new Triangle(new List<string> { "0", "1", "5" });

            //���������� � �������
            double x1 = t.v1._x;
            Console.WriteLine(x1);

            //� ��� ��� � �������
            double y1 = t.v1._y;
            Console.WriteLine();

            //�� �������
            double x2 = t.v2._x;

            Console.WriteLine();
            //������ ������ ������
            t.v1_id = 4;
            double x3 = t.v1._x;
            Console.WriteLine(x3);
        }
    }
}