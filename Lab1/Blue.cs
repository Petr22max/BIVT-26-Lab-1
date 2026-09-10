namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a>0 && b>0)
                answer = true;
            if (a<0 && b<0)
                answer = true;


            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            answer = Math.Abs(d % 1) >= 0.0001;

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0)
                if (a%b==0)
                    answer = true;

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = d;

            if (Math.Abs(f) > Math.Abs(answer))
                answer = f;

            if (Math.Abs(g) > Math.Abs(answer))
                answer = g;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x<=-1)
                answer = 0;
            else if (x>-1 && x<=0)
                answer= x+1;
            else
                answer = 1;

            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            if (Math.Pow(circleS/Math.PI,0.5) <= (Math.Pow(squareS,0.5)/2))
                answer = true;

            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            
            // end

            return answer;
        }
    }
}
