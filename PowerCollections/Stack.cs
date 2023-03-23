using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PowerCollections
{
    public class Stack<T> : IEnumerable  
    
        public T[] arr;
        public int Count; //Count - текущее число элементов в стеке
        public int Capacity; //Capacity - максимальный размер стека
        public T[] arr2;

        public Stack(int size = 100)
        {
            arr = new T[size];
            Capacity = size;
            Count = 0;
            arr2 = new T[size];
        }  
        
        public void Push(T element) //Push() - добавить элемент на вершину стека
        {            
            arr[Count++] = element;            
        }

        public T Pop() //Pop() - снять элемент с вершины и вернуть его значение
        {           
            return arr[--Count];           
        }

        public T Top() // Top() - вернуть значение элемента на вершине стека, но не извлекать
        {
            return arr[Count-1];  
        }
       
        public IEnumerator<T> GetEnumerator() // проходит по стеку "от вершины к низу"
        {           
            for(int i = Count-1,j = 0; i>=0 ; i--,j++)
            {
                 yield return arr[i];                              
            }
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
