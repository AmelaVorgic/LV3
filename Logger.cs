using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LV3
{
    class Logger
    {
        private string filename = "Untitled.txt";
        private Logger instance;

        public Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void SetName(string name)
        {
            this.filename = name;
        }

        public void LogToFile(string dataToWrite)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename))
            {
                writer.WriteLine(dataToWrite);
            }
        }
    }
}

//hoće, uporaba loggera na drugim mjesta u testu programa pisat će u istu datoteku zato što se ne mijenja putanja što znači da se datoteka ne mijenja