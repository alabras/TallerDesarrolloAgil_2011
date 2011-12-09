using System;
using System.Collections;
using Moq;

namespace Mocking
{
    class Program
    {
        static void Main()
        {
            Mocking();
            Stubbing();
        }

        private static void Mocking()
        {
            var mockedList = new Mock<ArrayList>();
            
            //using mock object 
            mockedList.Object.Add("one");
            mockedList.Object.Clear();

            //verification 
            mockedList.Verify(x=>x.Add("one"), Times.Once());
            mockedList.Verify(x=>x.Clear(), Times.Once());
        }

        private static void Stubbing()
        {
            var mockedList = new Mock<ArrayList>();
            //stubbing 
            mockedList.Setup(x => x[0]).Returns("firts");
            //following prints "first" 
            Console.WriteLine(mockedList.Object[0]);
            //following throws runtime exception
            Console.WriteLine(mockedList.Object[1]);

            //stubbing using built-in anyInt() argument matcher
            mockedList.Setup(x => x[It.IsAny<int>()]).Returns("element");
            Console.WriteLine(mockedList.Object[0]);
        }
    }
}
