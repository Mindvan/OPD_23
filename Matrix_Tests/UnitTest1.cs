using NUnit.Framework;
using OPD_23;
using System.Threading;
namespace Matrix_Tests
{
    public class Tests
    {
        [Test]
        public void MatrixSumTestSort()
        {
            int[][] matrixSumAsc = new int[][] {
                new int[] { -14, -6, 18 },
                new int[] { -2, 3, -1 },
                new int[] { 0, 11, -7 },
                new int[] { 4, 5, 2 },
                new int[] { 10, 8, 3 } };

            int[][] matrixSumDesc = new int[][] {
                new int[] { 10, 8, 3 },
                new int[] { 4, 5, 2 },
                new int[] { 0, 11, -7 },
                new int[] { -2, 3, -1 },
                new int[] { -14, -6, 18 } };

            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix();
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrix2.matrix);

            matrix1.setAlgorythm(new BubbleSort());
            matrix1.setType(new SumType(true));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixSumAsc);

            matrix1.setType(new SumType(false));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixSumDesc);
        }

        [Test]
        public void MatrixMaxTestSort()
        {
            int[][] matrixMaxAsc = new int[][] {
                new int[] { -2, 3, -1 },
                new int[] { 4, 5, 2 },
                new int[] { 10, 8, 3 },
                new int[] { 0, 11, -7 },
                new int[] { -14, -6, 18 }
            };

            int[][] matrixMaxDesc = new int[][] {
                new int[] { -14, -6, 18 },
                new int[] { 0, 11, -7 },
                new int[] { 10, 8, 3 },
                new int[] { 4, 5, 2 },
                new int[] { -2, 3, -1 } };

            Matrix matrix1 = new Matrix();
            matrix1.SortMatrix();
            matrix1.setAlgorythm(new BubbleSort());
            matrix1.setType(new MaxType(true));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixMaxAsc);

            matrix1.setType(new MaxType(false));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixMaxDesc);
        }

        [Test]
        public void MatrixMinTestSort()
        {
            int[][] matrixMinAsc = new int[][] {
                new int[] { -14, -6, 18 },
                new int[] { 0, 11, -7 },
                new int[] { -2, 3, -1 },
                new int[] { 4, 5, 2 },
                new int[] { 10, 8, 3 }
            };

            int[][] matrixMinDesc = new int[][] {
                new int[] { 10, 8, 3 },
                new int[] { 4, 5, 2 },
                new int[] { -2, 3, -1 },
                new int[] { 0, 11, -7 },
                new int[] { -14, -6, 18 }};

            Matrix matrix1 = new Matrix();
            matrix1.SortMatrix();
            matrix1.setAlgorythm(new BubbleSort());
            matrix1.setType(new MinType(true));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixMinAsc);

            matrix1.setType(new MinType(false));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixMinDesc);
        }
        [Test]

        public void CountdownTest()
        {
            Countdown cd = new Countdown();
            SubscriberA a = new SubscriberA();
            SubscriberB b = new SubscriberB();
            SubscriberC c = new SubscriberC();
            cd.Attach(a);
            cd.Attach(b);
            cd.Attach(c);
            cd.SendMessages("Hallo Ich Bin Ivan", 3000);
            Assert.AreEqual(cd.message, "Hallo Ich Bin Ivan");
            
        }
    }
}