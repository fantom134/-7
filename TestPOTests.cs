using ClassFunctions;
using NUnit.Framework;

namespace ТО1.Tests
{
    [TestFixture]
    public static class Tests
    {
        [Test]
        public static void Sort1()
        {
            int[] input = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            TestPO.MergeSort(input, 0, input.Length - 1);

            Assert.That(expected, Is.EqualTo(input));
        }

        [Test]

        public static void Sort2()
        {
            int[] input = { 13 };
            int[] expected = { 13 };

            TestPO.MergeSort(input, 0, 0);

            Assert.That(expected, Is.EqualTo(input));
        }

        [Test]

        public static void Sort3()
        {

            int[] input = { -3, 5, -1, 0, 2 };
            int[] expected = { -3, -1, 0, 2, 5 };

            TestPO.MergeSort(input, 0, input.Length - 1);

            Assert.That(expected, Is.EqualTo(input));
        }

        [Test]
        public static void Sort4()
        {
            int[] input = { 7, 7, 7, 7 };
            int[] expected = { 7, 7, 7, 7 };

            TestPO.MergeSort(input, 0, input.Length - 1);

            Assert.That(expected, Is.EqualTo(input));
        }

        [Test]
        public static void Polidrom1()
        {

            Assert.IsTrue(TestPO.Palindrome("aaa"));

        }

        [Test]
        public static void Polidrom2()
        {
            Assert.IsFalse(TestPO.Palindrome("add"));
        }

        [Test]
        public static void Polidrom3()
        {
            Assert.IsTrue(TestPO.Palindrome("12321"));
        }

        [Test]
        public static void Polidrom4()
        {
            Assert.IsTrue(TestPO.Palindrome("1"));
        }

        [Test]

        public static void Fact1()
        {

            int a = TestPO.Factorial(1);

            
            Assert.That(a, Is.EqualTo(1));
        }

        [Test]
        public static void Fact2()
        {
            Assert.That(TestPO.Factorial(5), Is.EqualTo(120));
        }

        [Test]
        public static void Fact3()
        {
            Assert.That(TestPO.Factorial(3), Is.EqualTo(6));
        }

        [Test]
        public static void Fact4()
        {
            Assert.That(TestPO.Factorial(-5), Is.EqualTo(-1));
        }

        [Test]
        public static void Fibonacci1()
        {
            Assert.That(TestPO.Fibonacci(10), Is.EqualTo(34));
        }

        [Test]
        public static void Fibonacci2()
        {
            Assert.That(TestPO.Fibonacci(20), Is.EqualTo(4181));
        }

        [Test]
        public static void Fibonacci3()
        {
            Assert.That(TestPO.Fibonacci(3), Is.EqualTo(1));
        }

        [Test]
        public static void Fibonacci4()
        {
            Assert.That(TestPO.Fibonacci(6), Is.EqualTo(5));
            Assert.That(TestPO.Fibonacci(7), Is.EqualTo(8));
        }

        [Test]
        public static void FindSubstring1()
        {
            bool result = TestPO.ContainsSubstring("Hello world", "world");
            Assert.That(result, Is.True);
        }

        [Test]
        public static void FindSubstring2()
        {
            bool result = TestPO.ContainsSubstring("abcabc", "bc");
            Assert.That(result, Is.True);
        }

        [Test]
        public static void FindSubstring3()
        {
            bool result = TestPO.ContainsSubstring("abc", "xyz");
            Assert.That(result, Is.False);
        }

        [Test]
        public static void FindSubstring4()
        {
            bool result = TestPO.ContainsSubstring("", "");
            Assert.That(result, Is.True);
        }

        [Test]
        public static void Prostoe1()
        {
            bool result = TestPO.Prostoe(2);
            Assert.That(result, Is.True);
        }

        [Test]
        public static void Prostoe2()
        {
            bool result = TestPO.Prostoe(17);
            Assert.That(result, Is.True);
        }

        [Test]
        public static void Prostoe3()
        {
            bool result = TestPO.Prostoe(10);
            Assert.That(result, Is.False);
        }

        [Test]
        public static void Prostoe4()
        {
            bool result = TestPO.Prostoe(1);
            Assert.That(result, Is.False);
        }

        [Test]
        public static void ReverseInt1()
        {
            int result = TestPO.ReverseInt(123);
            Assert.That(result, Is.EqualTo(321));
        }

        [Test]
        public static void ReverseInt2()
        {
            int result = TestPO.ReverseInt(-120);
            Assert.That(result, Is.EqualTo(-21));
        }

        [Test]
        public static void ReverseInt3()
        {
            int result = TestPO.ReverseInt(1534236469);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public static void ReverseInt4()
        {
            int result = TestPO.ReverseInt(0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public static void Rim1()
        {
            string result = TestPO.Rim(3);
            Assert.That(result, Is.EqualTo("III"));
        }

        [Test]
        public static void Rim2()
        {
            string result = TestPO.Rim(58);
            Assert.That(result, Is.EqualTo("LVIII"));
        }

        [Test]
        public static void Rim3()
        {
            string result = TestPO.Rim(1994);
            Assert.That(result, Is.EqualTo("MCMXCIV"));
        }

        [Test]
        public static void Rim4()
        {
            // Тест для числа 1, так как 0 вызывает исключение
            string result = TestPO.Rim(1);
            Assert.That(result, Is.EqualTo("I"));
        }

    }


}