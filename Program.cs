using System.Numerics;

namespace MatrixImaginary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector2(0.1f, 0.2f);
            var v2 = new Vector2(1.1f, 2.2f);
            var vResult = v1 + v2;

            var v11 = new Vector2(0.1f, 0.2f);
            var v12 = new Vector2(1.1f, 2.2f);
            var vResult1 = Vector2.Dot(v11, v12);
            var vResult2 = Vector2.Distance(v11, v12);
            var vResult3 = Vector2.Clamp(v11, Vector2.Zero, Vector2.One);


            var m1 = new Matrix4x4(
            1.1f, 1.2f, 1.3f, 1.4f,
            2.1f, 2.2f, 3.3f, 4.4f,
            3.1f, 3.2f, 3.3f, 3.4f,
            4.1f, 4.2f, 4.3f, 4.4f);

            var m2 = Matrix4x4.Transpose(m1);
            var mResult = Matrix4x4.Multiply(m1, m2);

            Console.WriteLine("Hello, World!");
        }
    }
}
