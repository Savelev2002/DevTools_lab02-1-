using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PowerCollections.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void MaximumStackSize()
        {
            // arrange настройка

            int SizeOfStack = 3;

            // act выполнить

            Stack<int> stack = new Stack<int>(SizeOfStack);
        
            // assert правильно или неправильно

            Assert.AreEqual(SizeOfStack, stack.Capacity);
        }

        [TestMethod]
        public void Push_2_ElementsToStack_Get_Quantity_2()
        {            
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);           
            Assert.AreEqual(stack.Count, 2);
        }

        [TestMethod]
        public void Push_3_ElementsToStack_Get_ElementTop()
        {         
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int top1 = stack.Top();
            int top2 = stack.Top();

            Assert.AreEqual(3, top1);
            Assert.AreEqual(3, top2);

        }

        [TestMethod]
        public void Push_3_ElementsToStack_Pop_3_Elements()
        {
       
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
          
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void Push_3_ElementsToStack_Get_From_TopToBottom()
        {
            const int SizeOfStack = 3;
            int[] arr = new int[SizeOfStack] { 1, 2, 3 };
            int[] ArayReverse = new int[SizeOfStack] { 3, 2, 1 };
            int[] ArayReverse1 = new int[SizeOfStack];

            Stack<int> stack = new Stack<int>(SizeOfStack);
            for (int i = 0; i < SizeOfStack; i++)
            {
                stack.Push(arr[i]);
            }

            int b = 0;
            foreach (var i in stack)
            {
                ArayReverse1[b++] = i;
            }
            
            CollectionAssert.AreEqual(ArayReverse, ArayReverse1);
        }

        // Errors

        [TestMethod]       
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void FillMoreThanSizeOfStack_GetIndexOutOfRangeExceptionError()
        {         
            Stack<int> stack = new Stack<int>(1);

            stack.Push(1);
            stack.Push(2);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TakeMoreThanAmountOnStack_GetIndexOutOfRangeExceptionError()
        {            
            Stack<int> stack = new Stack<int>(1);

            stack.Push(1);

            stack.Pop();
            stack.Pop();
        }
    }
}
