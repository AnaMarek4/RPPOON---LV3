using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class NotificationBuilder : IBuilder
    {
        public String author = "Stephen King";
        public String title = "Green Mile";
        public String text = "I'm tired.";
        public DateTime timestamp = DateTime.Now;
        public Category level = Category.INFO;
        public ConsoleColor color = ConsoleColor.Green;

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, timestamp, level, color);
        }

        public IBuilder SetAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.title = title;
            return this;
        }

        public IBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.timestamp = time;
            return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }
    }
}
