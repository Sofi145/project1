
namespace R.R
{
    class SolvingLinearEquation
    {
        private (float, float) x;

        public (float, float) X
        {
            get { return x; }
            set { x = value; }
        }
        public float Solve(float b, float c)
        {
            if (c == 0)
                X = (0, 0);

            if (b == 0 && c == 0)
                X = (float.MaxValue, float.MaxValue);

            X = (-c / b, -c / b);

            return X.Item1;
        }
    }
}
