
using System;
using System.Collections.Generic;

namespace R.R
{
    class SolvingQuadraticEquation : SolvingLinearEquation
    {
        private float discriminant;

        public float Discriminant
        {
            get { return discriminant; }
            set { discriminant = value; }
        }

        public List<float> Solve(float a, float b, float c)
        {
            List<float> rootsEquation = new List<float>();

            if (a == 0)
                X = (float.MaxValue, float.MaxValue);

            CalculatingDiscriminant(a, b, c);

            if (Discriminant < 0)
                X = (float.MaxValue, float.MaxValue);

            else if (Discriminant == 0)
                X = (-b / (2 * a), -b / (2 * a));

            else if (Discriminant > 0)
                X = ((float)(-b + Math.Sqrt(Discriminant)) / (2 * a), (float)(-b - Math.Sqrt(Discriminant)) / (2 * a));

            rootsEquation.Add(X.Item1);
            rootsEquation.Add(X.Item2);

            return rootsEquation;
        }

        protected float CalculatingDiscriminant(float a, float b, float c) => Discriminant = (float)(Math.Pow(b, 2) - 4 * a * c);
    }
}
