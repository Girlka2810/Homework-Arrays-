using NUnit.Framework;
using Arrays;
namespace ArraysTests
{
    public class Tests
    {
        [TestCase(new int[] { 1, 2, 3 },1)]
        [TestCase(new int[] { 4, 42212, 3,233,42 }, 3)]
        [TestCase(new int[] { -1, 23242, 413 }, -1)]
        [TestCase(new int[] { -1231, 79872, 3423 }, -1231)]

        public void MinElemTest(int[]a,int expected)
        {
            int actual = Arrays.ArraysMethods.FindMinElemOfArr(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 4, 42212, 3, 233, 42 }, 42212)]
        [TestCase(new int[] { -1, 23242, 413 }, 23242)]
        [TestCase(new int[] { -1231, 79872, 3423 }, 79872)]

        public void MaxElemTest(int[]a, int expected)
        {
            int actual = Arrays.ArraysMethods.FindMaxElemOfArr(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 4, 42212, 3, 233, -42 }, 4)]
        [TestCase(new int[] { -1, 23242, -413 }, 2)]
        [TestCase(new int[] { -1231, 79872, 342303 }, 0)]

        public void FindIndexOfMinElemTest(int []a, int expected)
        {
            int actual = Arrays.ArraysMethods.FindIndexOfMinElem(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 4, 42212, 3, 233, -42 }, 1)]
        [TestCase(new int[] { -1, 23242, -413 }, 1)]
        [TestCase(new int[] { -1231, 79872, 342303 }, 2)]

        public void FindIndexOfMaxElemTest(int[] a, int expected)
        {
            int actual = Arrays.ArraysMethods.FindIndexOfMaxElem(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 4, 42212, 3, 233, -42 }, 42212+233)]
        [TestCase(new int[] { -1, 23242, -413 }, 23242)]
        [TestCase(new int[] { -1231, 79872, 342 }, 79872)]

        public void FindSummOfOddIndexElemTest(int[] a, int expected)
        {
            int actual = Arrays.ArraysMethods.FindSummOfOddIndexElem(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 },new int[] {3,2,1} )]
        [TestCase(new int[] { 4, 42212, 3, 233, -42 }, new int[] { -42,233,3,42212,4 } )]
        [TestCase(new int[] { -1, 23242, -413 }, new int[] { -413,23242,-1 })]
        [TestCase(new int[] { -1231, 79872, 342 }, new int[] { 342,79872,-1231 })]

        public void ReversArrayTest(int[] a, int[] expected)
        {
            int[] actual = Arrays.ArraysMethods.ReversArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 4, 42212, 3, 233, -42 }, 2)]
        [TestCase(new int[] { -1, 23242, -413,1212,1232,543,56789,1235 }, 4)]
        [TestCase(new int[] { -1231, 79872, 342,125,2154,2356,488,654,89,4,2,66,4,6,6487,5,0 }, 8)]

        public void SumOfOddElementQuantityTest(int[] a, int expected)
        {
            int actual = Arrays.ArraysMethods.SumOfOddElementQuantity(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 4, 42212, 3, 233, -42 }, new int[] { 233, -42, 3, 4, 42212 })]
        [TestCase(new int[] { -1, 23242, -413 }, new int[] { -413, 23242, -1 })]
        [TestCase(new int[] { -1231, 79872, 342,10 }, new int[] { 342, 10,  -1231,79872 })]
        [TestCase(new int[] { 1,2,3,4,5,6 }, new int[] { 4,5,6,1,2,3 })]

        public void SortArrayChangeTheHalfTest(int[] a, int[] expected)
        {
            int[]actual = Arrays.ArraysMethods.SortArrayChangeTheHalfs(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 3,2,1 }, new int[] { 1,2,3 })]
        [TestCase(new int[] { 10,2,43,67,98}, new int[] { 2,10,43,67,98 })]
        [TestCase(new int[] {15,3,321,45,78,6,23,4,0 }, new int[] { 0,3,4,6,15,23,45,78,321 })]
        [TestCase(new int[] { 5,-1,0,78,6,1215,-1254 }, new int[] { -1254,-1,0,5,6,78,1215 })]

        public void SortArraySelectionTest(int[] a, int[] expected)
        {
            int[] actual = Arrays.ArraysMethods.SortAraySelection(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 10, 2, 43, 67, 98 }, new int[] { 98,67,43,10,2 })]
        [TestCase(new int[] { 15, 3, 321, 45, 78, 6, 23, 4, 0 }, new int[] { 321,78,45,23,15,6,4,3,0 })]
        [TestCase(new int[] { 5, -1, 0, 78, 6, 1215, -1254 }, new int[] { 1215,78,6,5,0,-1,-1254})]

        public void SortArrayBubbleTest(int[] a, int[] expected)
        {
            int[] actual = Arrays.ArraysMethods.SortArrayBubble(a);
           
            Assert.AreEqual(expected, actual);
        }
    }
}