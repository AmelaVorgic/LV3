using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    public enum Category { ERROR, ALERT, INFO }
    class ConsoleNotification : Prototype
    {
        public string Author { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }

        public ConsoleNotification(string author, string title, string text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }
    }
}

//7.zadatak - Funkcionalno nema razlike između plitkog i dubokog kopiranja, svakako se objekt te klase ne može mijenjati, setteri su private
