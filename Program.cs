using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCsv("TestId", "test", "10", "TestCsv.txt");
            Dataset file = new Dataset("TestCsv.txt");
            file.Clone();

            double[][] testmatrix = RandomMatrixGenerator.GetInstance().GenerateMatrix(3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(testmatrix[i][j].ToString() + " ");
                }
                Console.WriteLine();
            }

            Logger logger = new Logger();
            logger.GetInstance().SetName("MyTestFile.txt");
            logger.GetInstance().LogToFile("accept");

            ConsoleNotification notification = new ConsoleNotification("Amela", "Student", "Check", DateTime.Now, Category.INFO, ConsoleColor.Yellow);
            NotificationManager manager = new NotificationManager();
            manager.Display(notification);
            NotificationDirector director = new NotificationDirector();

            ConsoleNotification Message = director.CreateERRORNotification("Owner");
            ConsoleNotification Notification = director.CreateINFONotification("Owner");
            ConsoleNotification Warning = director.CreateALERTNotification("Owner");

        }
        public static void CreateCsv(string ID, string name, string age, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine(ID + "," + name + "," + age);
                }
            }
            catch (Exception ex)
            {
                throw new AccessViolationException("Error!", ex);
            }
        }

    }
}
