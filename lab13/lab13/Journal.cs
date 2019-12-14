using System;
using System.Collections.Generic;
using System.Text;
using MyLib;

namespace lab13
{
    class JournalEntry
    {
        public string Name { get; set; }
        public string TypeEvent { get; set; }
        public string NameEvent { get; set; }
        public Transport Object { get; set; }
        public JournalEntry(string name, string type, string nameEvent, Transport Object)
        {
            Name = name;
            TypeEvent = type;
            NameEvent = nameEvent;
            this.Object = Object;
        }
        public JournalEntry(Transport Object, int num)
        {
            Name = "MyNewCollection";
            TypeEvent = "Изменение количества элементов";
            NameEvent = "Добавление элемента не по умолчанию";
            this.Object = Object;
        }
        public JournalEntry()
        {
            Name = "MyNewCollection";
            TypeEvent = "Изменение количества элементов";
            NameEvent = "Добавление элемента по умолчанию";
            Object = new Transport();
        }

        public override string ToString()
        {
            return "\nНазвание класса: " +
                Name + "\nТип события: " +
                TypeEvent + "\nНаименование события: " + NameEvent +
                "\n\nСобытие произошло с элементом \n" + Object + "\n";
        }
    }

    public class Journal
    {
        List<JournalEntry> journals = new List<JournalEntry>();
        public void CollectionCountChanged(object source, MyNewCollectionEventArg args)
        {
            JournalEntry nwE = new JournalEntry(args.NameCollections, args.TypeEvent, args.NameEvent, args.Object);
            journals.Add(nwE);
        }
        public void CollectionReferenceChanged(object source, MyNewCollectionEventArg args)
        {
            JournalEntry nwE = new JournalEntry(args.NameCollections, args.TypeEvent, args.NameEvent, args.Object);
            journals.Add(nwE);
        }

        public override string ToString()
        {
            if (journals.Count == 0) return "Журнал пуст!";
            string s = "";
            foreach (JournalEntry it in journals)
            {
                s += it + "\n\n";
            }
            return s;
        }
        public void Clear()
        {
            journals.Clear();
        }
    }
}
