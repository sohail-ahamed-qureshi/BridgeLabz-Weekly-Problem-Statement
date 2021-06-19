using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// interface with operation methods.
    /// </summary>
    interface IOperations
    {
        void Add(int firstNum, int secondNum);
        void Substract(int firstNum, int secondNum);
        const double PI = 3.146;
    }
    abstract class Opertions
    {
        //properties
        private int firstOper;
        private int secondOper;
        public int FirstOper
        {
            get
            {
                return firstOper;
            }
            set
            {
                firstOper = value;
            }
        }
        public int SecondOper
        {
            get
            {
                return secondOper;
            }
            set
            {
                secondOper = value;
            }
        }
        public void Multiplication(int firstOper, int secondOper)
        {
            this.FirstOper = firstOper;
            this.SecondOper = secondOper;
            int result = FirstOper * SecondOper;
            Console.WriteLine(result);
        }
        public int Division(int firstNum, int secondNum)
        {
            this.FirstOper = firstNum;
            this.SecondOper = secondNum;
            int result = FirstOper / SecondOper;
            return result;
        }
        public abstract void Mod(int firstNum);
        public abstract void Increment(int firstNum);
    }
    class CirleArea : Opertions, IOperations
    {
        //properties
        private int firstNum;
        private int secondNum;
        public int FirstNum 
        {
            get
            {
                return firstNum;
            }
            set
            {
                firstNum = value;
            }
        }
        public int SecondNum
        {
            get
            {
                return secondNum;
            }
            set
            {
                secondNum = value;
            }
        }
        /// <summary>
        /// calculate Circle area.
        /// formula Area = PI * r * r.
        /// </summary>
        public void CircularArea()
        {
            int radius = 10;
            double result = IOperations.PI * Math.Pow(radius, 2);
            Console.WriteLine(result);
        }
        /// <summary>
        /// Add method inherited from Ioperations
        /// </summary>
        public void Add(int firstNum, int secondNum)
        {
            this.FirstNum = firstNum;
            this.SecondNum = secondNum;
            int result = FirstNum + SecondNum;
            Console.WriteLine(" Add method "+result);
        }
        /// <summary>
        /// abstract method post increment
        /// </summary>
        public override void Increment(int firstNum)
        {
            this.FirstNum = firstNum;
            Console.WriteLine(FirstNum++);
        }
        /// <summary>
        /// Abstract method from Operations class, performs Modulo operation od 2.
        /// </summary>
        /// <param name="firstNum">input from user</param>
        public override void Mod(int firstNum)
        {
            this.FirstNum = firstNum;
            int result = FirstNum % 2;
            Console.WriteLine(result);
        }
        /// <summary>
        /// Sub method inherited from Ioperations
        /// </summary>
        public void Substract(int firstNum, int secondNum)
        {
            this.FirstNum = firstNum;
            this.secondNum = secondNum;
            int result = FirstNum - SecondNum;
            Console.WriteLine(result);
        }
    }
}
