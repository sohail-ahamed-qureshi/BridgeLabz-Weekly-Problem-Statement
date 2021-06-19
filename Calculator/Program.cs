using System;

namespace Calculator
{
    /// <summary>
    /// ---Weekly activity---
    /// inter face :
    // methods
    //1.add
    //2.sbstract
    //// const
    //const double pi = 3.146

    //Abstact class:
    //1. mutiplication // normal method
    //2. division // normal method
    //3. abstact mod //abstact method
    //4. abstract Increment //abstact method

    //new class :
    //that Inherit Both Abstract class and Interface, and implement Methods:
    //1. Circular CircleArea(int radius)  // normal method,  formula pi*radious* radious
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calculator
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator using OOPs");

            //upcasting
            Opertions opertions = new CirleArea();
            opertions.Multiplication(10, 20);

            IOperations opertions1 = new CirleArea();
            opertions1.Add(10, 20);

            //downcasting
            CirleArea cirleArea = (CirleArea)opertions;
            cirleArea.Division(11, 22);

            CirleArea cirleArea1 = (CirleArea)opertions1;
            cirleArea1.Substract(10, 20);
        }
    }
}
