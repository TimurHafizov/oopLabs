using System;
using System.Collections.Generic;
using System.Text;
using MyLib;

namespace lab13
{
    public class MyNewCollectionEventArg : EventArgs
    {
        public string NameCollections { get; private set; }
        public string TypeEvent { get; private set; }
        public string NameEvent { get; private set; }
        public Transport Object { get; private set; }

        public MyNewCollectionEventArg(string name, string type, string nameEvent, Transport obj)
        {
            NameCollections = name;
            TypeEvent = type;
            NameEvent = nameEvent;
            Object = obj;
        }
        public MyNewCollectionEventArg(Transport obj)
        {
            NameCollections = "MyNewCollection";
            TypeEvent = "Изменение количества элементов";
            NameEvent = "Добавление одного элемента не по умолчанию";
            Object = obj;
        }
        public MyNewCollectionEventArg()
        {
            NameCollections = "MyNewCollection";
            TypeEvent = "Изменение количества элементов";
            NameEvent = "Добавление элемента по умолчанию";
            Object = new Transport();
        }
        public override string ToString()
        {
            return "Название класса: " + NameCollections + "\nТип события: " + TypeEvent + "\nНаименование события: " + NameEvent + "\n\nСобытие произошло с элементом \n" + Object + "\n";
        }
    }
}

