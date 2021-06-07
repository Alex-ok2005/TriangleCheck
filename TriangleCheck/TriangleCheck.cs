using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class TriangleCheck
    {
        // Типы треугольников 
        public enum TriangleType
        {
            None = 0,   // не является
            Acute = 1,  // остроугольный
            Right = 2,  // прямой
            Obtuse = 3  // тупоугольный
        }
        // Проверка типа треугольника 
        public TriangleType Check(double s1, double s2, double s3)
        {
            if (s1 + s2 <= s3 || s2 + s3 <= s1 || s1 + s3 <= s2) return TriangleType.None;
            var q1 = s1 * s1;
            var q2 = s2 * s2;
            var q3 = s3 * s3;
            if (q1 + q2 < q3 || q1 + q3 < q2 || q2 + q3 < q1) return TriangleType.Obtuse;
            else if (q1 + q2 == q3 || q1 + q3 == q2 || q2 + q3 == q1) return TriangleType.Right;
            return TriangleType.Acute;
        }
    }
}
