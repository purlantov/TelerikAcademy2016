using System;
namespace Matrix_Generic
{
    public class GenericList<T> where T:struct
    {
        private const int DefaultCapacity = 16;
        private int capacyty;
        private T[] list;

        public GenericList()
        {
            this.list = new T[DefaultCapacity];
        }

        public T[] Grow()
        {
            this.list = new T[list.Length * 2];

            return list;
        }

        public void AddElement()
        {
            for (int i = 0; i < list.Length; i++)
            {
                
            }
        }
    }
}
