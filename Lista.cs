using System;

namespace ConsoleDrawer {

    public class Lista {

        private readonly object[] _items;
        public int Count {get; private set;}

        public Lista(int limit) {
            _items = new object[limit];
            Count = 0;

        }

        public void Add (object item) {
            if(Count == _items.Length) {
                throw new System.InvalidOperationException();    

            }
            _items[Count] = item;
            Count ++;

        }

    }
    
}