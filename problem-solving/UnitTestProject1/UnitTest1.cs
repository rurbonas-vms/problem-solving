﻿using System;
using NUnit.Framework;
using problem_solving;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        [TestCase(new int[] { 1, 2 }, 3)]
        [TestCase(new int[] { -1, -1, -1 }, -3)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(null, 0, ExpectedException = typeof(ArgumentNullException))]
        [TestCase(new int[] { Int32.MaxValue }, Int32.MaxValue)]
        [TestCase(new int[] { Int32.MinValue, Int32.MaxValue }, -1)]
        [TestCase(new int[] { Int32.MaxValue, Int32.MaxValue, Int32.MaxValue }, 6442450941)]
        public void Test_SumArray(int[] arr, long result)
        {
            Assert.AreEqual(result, Program.SumArray(arr));
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, 1)]
        [TestCase(new int[] { -1, -1, -1 }, -3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 25)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(null, null, ExpectedException = typeof(ArgumentNullException))]
        [TestCase(new int[] { Int32.MaxValue }, Int32.MaxValue)]
        [TestCase(new int[] { Int32.MinValue, Int32.MaxValue }, Int32.MaxValue)]
        [TestCase(new int[] { Int32.MinValue, Int32.MinValue, Int32.MinValue, Int32.MinValue, 5 }, 5)]
        public void Test_SumArrayOddValues(int[] arr, long result)
        {
            Assert.AreEqual(result, Program.SumArrayOddValues(arr));
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, 2)]
        [TestCase(new int[] { -1, -1, -1 }, -1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 30)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(null, null, ExpectedException = typeof(ArgumentNullException))]
        [TestCase(new int[] { Int32.MaxValue }, 0)]
        [TestCase(new int[] { Int32.MinValue, Int32.MaxValue }, Int32.MaxValue)]
        [TestCase(new int[] { Int32.MinValue, Int32.MinValue, Int32.MinValue }, Int32.MinValue)]
        public void Test_SumArrayEverySecondValue(int[] arr, long result)
        {
            Assert.AreEqual(result, Program.SumArrayEverySecondValue(arr));
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 })]
        [TestCase(new int[] { -1, -1, -1 }, new int[] { -1 })]
        [TestCase(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(null, null, ExpectedException = typeof(ArgumentNullException))]
        [TestCase(new int[] { Int32.MaxValue }, new int[] { Int32.MaxValue })]
        [TestCase(new int[] { Int32.MinValue, Int32.MinValue, Int32.MinValue }, new int[] { Int32.MinValue })]
        public void Test_GetUniqueValues(int[] arr, int[] result)
        {
            Assert.AreEqual(result, Program.GetUniqueValues(arr));
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 }, new int[] { 1, 2 })]
        [TestCase(new int[] { -1, -1, -1 }, new int[] { -1 }, new int[] { -1 })]
        [TestCase(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 }, new int[] { 1, 2 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(null, null, null, ExpectedException = typeof(ArgumentNullException))]
        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { })]
        public void Test_IntersectArrays(int[] arrA, int[] arrB, int[] result)
        {
            Assert.AreEqual(result, Program.GetArrayIntersect(arrA, arrB));
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 }, new int[] { })]
        [TestCase(new int[] { -1, -1, -1 }, new int[] { -1 }, new int[] { })]
        [TestCase(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 }, new int[] { 1, 2 }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(null, null, null, ExpectedException = typeof(ArgumentNullException))]
        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 5 })]
        public void Test_GetArrayNotIntersect(int[] arrA, int[] arrB, int[] result)
        {
            Assert.AreEqual(result, Program.GetArrayNotIntersect(arrA, arrB));
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, 3, true)]
        [TestCase(new int[] { 1, 2 }, 5, false)]
        [TestCase(new int[] { -1, -1, -1 }, -2, true)]
        [TestCase(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 }, 4, true)]
        [TestCase(new int[] { 0 }, 0, false)]
        [TestCase(new int[] { }, 1, false)]
        [TestCase(null, null, null, ExpectedException = typeof(NullReferenceException))]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 6, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 7, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 8, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 9, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 10, false)]
        [TestCase(new int[] { Int32.MinValue, Int32.MaxValue }, -1, true)]
        public void Test_HasSum(int[] arr, long target, Boolean result)
        {
            Assert.AreEqual(result, Program.HasSum(arr, target));
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, 3)]
        [TestCase(new int[] { 1, 2, 2, 3 }, 4)]
        [TestCase(new int[] { -1, -1, -1 }, 0)]
        [TestCase(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, 0)]
        [TestCase(null, null, ExpectedException = typeof(ArgumentNullException))]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 5 }, 10)]
        [TestCase(new int[] { Int32.MinValue, Int32.MaxValue }, -1)]
        [TestCase(new int[] { Int32.MinValue, Int32.MaxValue, Int32.MaxValue }, Int32.MinValue)]
        public void LoneSum(int[] arr, int result)
        {
            Assert.AreEqual(result, Program.LoneSum(arr));
        }

        [Test]
        [TestCase("", "")]
        [TestCase(" ", "  ")]
        [TestCase("ABCDE", "AABBCCDDEE")]
        [TestCase(null, null, ExpectedException = typeof(ArgumentNullException))]
        [TestCase("☺", "☺☺")]
        public void Test_DoubleString(String s, String result)
        {
            Assert.AreEqual(result, Program.DoubleString(s));
        }

        [Test]
        [TestCase("", 'a', 0)]
        [TestCase(" ", ' ', 1)]
        [TestCase("ABCDE", 'A', 1)]
        [TestCase("Lorem Ipsum", 'm', 2)]
        [TestCase("AAAAAAAAAA", 'A', 10)]
        [TestCase("AAA\n", '\\', 0)]
        [TestCase("AAA\n", '\n', 1)]
        [TestCase(@"\\\\\\\\\\", '\\', 10)]
        [TestCase(null, 'a', 0, ExpectedException = typeof(ArgumentNullException))]
        [TestCase("☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺", '☺', 20)]
        public void Test_CountChars(String s, char c, int result)
        {
            Assert.AreEqual(result, Program.CountChars(s, c));
        }

        [Test]
        [TestCase("A1B2C3D4", 10)]
        [TestCase("", 0)]
        [TestCase("ABCDE", 0)]
        [TestCase("12345", 15)]
        [TestCase("\0\n\\", 0)]
        [TestCase("1\0", 1)]
        [TestCase("1\01", 2)]
        [TestCase("\x0031\x0032\x0033\x0034", 10)]
        [TestCase(null, 0, ExpectedException = typeof(ArgumentNullException))]
        [TestCase("☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺", 0)]
        public void Test_SumDigits(String s, int result)
        {
            Assert.AreEqual(result, Program.SumDigits(s));
        }

        [Test]
        [TestCase("A1B2C3D4", 10)]
        [TestCase("1   1   1   1   1", 5)]
        [TestCase("ABC123", 123)]
        [TestCase("123ABCDEF456", 579)]
        [TestCase("", 0)]
        [TestCase("ABCDE", 0)]
        [TestCase("12345", 12345)]
        [TestCase("\0\n\\", 0)]
        [TestCase("1\0", 1)]
        [TestCase("1\01", 2)]
        [TestCase("\x0031\x0032\x0033\x0034", 1234)]
        [TestCase("\x0031x\x0032x\x0033x\x0034x", 10)]
        [TestCase(null, 0, ExpectedException = typeof(ArgumentNullException))]
        [TestCase("☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺", 0)]
        public void Test_SumNumbers(String s, int result)
        {
            Assert.AreEqual(result, Program.SumNumbers(s));
        }

        [Test]
        [TestCase("", "", true)]
        [TestCase("   ", "   ", true)]
        [TestCase("    ", "   ", false)]
        [TestCase("A", "A", true)]
        [TestCase("abcd", "abcd", true)]
        [TestCase("abcd", "dcab", true)]
        [TestCase("abcd", "dcababcd", false)]
        [TestCase("abcd", "efgh", false)]
        [TestCase("abcd", "", false)]
        [TestCase("\n", "n\\", false)]
        [TestCase(null, null, true, ExpectedException = typeof(NullReferenceException))]
        [TestCase("☺☺☺☺", "☺☺☺☺", true)]
        [TestCase("☺☺☺☺", "☺☺☺☺☺☺☺☺", false)]
        public void Test_IsAnagram(String s1, String s2, bool result)
        {
            Assert.AreEqual(result, Program.IsAnagram(s1, s2));
        }

        [Test]
        [TestCase(19, 21, 21)]
        [TestCase(19, 22, 19)]
        [TestCase(22, 22, 0)]
        [TestCase(19, 19, 19)]
        [TestCase(20, 10, 20)]
        [TestCase(21, 20, 21)]
        [TestCase(18, 24, 18)]
        [TestCase(1, 1, 1)]
        [TestCase(1, Int32.MaxValue, 1)]
        public void Test_BlackJack(int c1, int c2, int result)
        {
            Assert.AreEqual(result, Program.BlackJack(c1, c2));
        }
    }
}