using System;
using StringCalculatorKata.App;
//using Xunit;
using NUnit.Framework;
//using Assert = Xunit.Assert;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        /*
         *  Prerequsites
         * 	    Visual Studio 2015
         *      .Net 4.5 or higher
         *      XUnit
         *      Core & Test projects
         *      Nuget
         *       
         *  Your Mission....
         *  -----------------
         *  
         *  Firstly restore all nuget packages
         *  
         *  Use TDD techniques to create a STRING CALCULATOR that takes a delimited set of numbers and returns the sum as the output.
         *  
         *  E.g. "10" = 10
         *       "2,4,9" = 15
         *       "2,4,9,5" =20
         *  
         *  Complete the mission by making the tests go GREEN one at a time!
         *  
         *  Remember the test class names describe the nature of the test, example of inputs is provided in the tests in notes.
         * 
         *  Aside from the standard functionality, if you have time try to:
         *    Allow any delimiter to be used, not just a comma
         *    Ignore any numbers more than 100
         *    Return 0 if a non numeric value is entered
         *    Throw a custom exception if the first 7 numbers match the Fibonacci Sequence
         *  
         *  DON'T WORRY if you can't complete all tests!
         * 
         *  The test uses the XUnit testing framework, please feel free to refer to the documentation @ https://xunit.github.io/
         */

        [Test]
        public void Calculate_EmptyString_ReturnsZero()
        {
            //e.g. "" = 0
            var calculator = new StringCalculator();
            var result = calculator.Add("");
            Assert.AreEqual(0, result);
        }

        //[Fact (Skip = "complete previous test first")]
        [Test]
        public void Calculate_SingleNumber_ReturnsSameNumber()
        {
            //e.g. "1" = 1
            var calculator = new StringCalculator();
            var result = calculator.Add("1");
            Assert.AreEqual(1, result);
        }

        //[Fact (Skip = "complete previous test first")]
        [Test]
        public void Calculate_TwoNumbers_ReturnsSum()
        {
            //e.g. "1,2" = 3
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2");
            Assert.AreEqual(3, result);
        }

        //[Fact(Skip = "complete previous test first")]
        [Test]
        public void Calculate_FiveNumbers_ReturnsSum()
        {
            //e.g. "1,2,3,4,5" = 15
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,3,4,5");
            Assert.AreEqual(15, result);
        }

        //[Fact(Skip = "complete previous test first")]
        [Test]
        public void Calculate_CanUseAlternativeDelimiters_ReturnsSum()
        {
            //e.g. "1|2|3" = 6
            var calculator = new StringCalculator();
            var result = calculator.Add("1|2|3");
            Assert.AreEqual(6, result);
        }

        //[Fact(Skip = "complete previous test first")]
        [Test]
        public void Calculate_NumbersLargerThan100_IgnoresOver100sInSum()
        {
            //e.g. "1,2,100" = 3
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,100");
            Assert.AreEqual(3, result);
        }

        //[Fact(Skip = "complete previous test first")]
        [Test]
        public void Calculate_NonNumericValue_ReturnsZero()
        {
            //e.g. "1,Elephant,6" = 0
            var calculator = new StringCalculator();
            var result = calculator.Add("1,Elephant,6");
            Assert.AreEqual(0, result);
        }

        //[Fact(Skip = "complete previous test first")]
        [Test]
        public void Calculate_FirstSevenInFibonacciSequence_ThrowsCustomFibonacciAlertException()
        {
            //e.g. "0,1,1,2,3,5,8" = FibonacciAlertException!
            var calculator = new StringCalculator();
            Assert.That(() => calculator.Add("0,1,1,2,3,5,8"), Throws.TypeOf<ArgumentException>()
                .With.Matches<ArgumentException>(x => x.Message == "FibonacciAlertException!"));
        }
    }
}