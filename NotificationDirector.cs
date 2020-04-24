using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    class NotificationDirector
    {
        public ConsoleNotification CreateINFONotification(string author)
        {

            NotificationBuilder note = new NotificationBuilder();
            note.SetAuthor(author);
            note.SetTitle("Informations!");
            note.SetLevel(Category.INFO);
            note.SetColor(ConsoleColor.Green);
            note.SetText("Content");

            return note.Build();
        }

        public ConsoleNotification CreateERRORNotification(string author)
        {

            NotificationBuilder note = new NotificationBuilder();
            note.SetAuthor(author);
            note.SetTitle("Error!");
            note.SetLevel(Category.ERROR);
            note.SetColor(ConsoleColor.White);
            note.SetText("Content");

            return note.Build();
        }

        public ConsoleNotification CreateALERTNotification(string author)
        {

            NotificationBuilder note = new NotificationBuilder();
            note.SetAuthor(author);
            note.SetTitle("Alert!");
            note.SetLevel(Category.ALERT);
            note.SetColor(ConsoleColor.Red);
            note.SetText("Content");

            return note.Build();
        }
    }
}