using System;
using System.Collections.Generic;
using System.Text;
using MyLib;

namespace lab13
{
    public delegate void MyCollectionHandler(object source, MyNewCollectionEventArg args);
    class MyNewCollection : MyCollection
    {
        public event MyCollectionHandler CollectionCountChanges;
        public event MyCollectionHandler CollectionReferenceChanges;

        public void OnCollectionCountChanges(object source, MyNewCollectionEventArg args)
        { 
            CollectionCountChanges?.Invoke(source, args);
        }
        public void OnCollectionReferencechanges(object source, MyNewCollectionEventArg args)
        {
            CollectionReferenceChanges?.Invoke(source, args);
        }

        public override void Add(Transport[] arr)
        {
            OnCollectionCountChanges(this, new MyNewCollectionEventArg("MyNewCollection", "Изменение количества элементов", "Добавление массива", arr[0]));
            base.Add(arr);
        }
        public override void AddDefault()
        {
            OnCollectionCountChanges(this, new MyNewCollectionEventArg());
            base.AddDefault();
        }
        public override void Add(Transport item)
        {
            OnCollectionCountChanges(this, new MyNewCollectionEventArg(item));
            base.Add(item);
        }
        public override bool Remove(int index)
        {
            OnCollectionCountChanges(this, new MyNewCollectionEventArg("MyNewCollection", "Изменение количества элементов", "Удаление элемента", this[index]));
            return base.Remove(index);
        }

        public override Transport this[int index]
        {
            get => base[index];
            set
            {
                OnCollectionReferencechanges(this, new MyNewCollectionEventArg("MyNewCollection", "Изменение количества элементов", "Изменение элемента", this[index]));
                base[index] = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

