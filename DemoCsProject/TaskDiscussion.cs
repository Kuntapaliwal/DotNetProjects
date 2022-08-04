namespace Discussion1
{
    public class Tasks
    {
        public string IsLeapYear(int year)
        {
            string ans;
            bool leap = false;
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        leap = true;
                    else
                        leap = false;
                }
                else
                    leap = true;
            }

            else
                leap = false;

            if (leap)
                ans = "it is a leap year.";
            else
                ans = "it is not a leap year.";

            return ans;
        }
        public int NumberIdentification(int n)
        {
            if (n < 0)
                return -1;
            else if (n > 0)
                return 1;
            else
                return 0;
        }
        public int[] getHighestLowest(int[] value)
        {
            System.Console.WriteLine("inside method");
            int n = value.Length;
            int[] ans = new int[2];
            int highest = int.MinValue;
            int lowest = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("inside loop");
                if (highest < value[i])
                    highest = value[i];
                if (lowest > value[i])
                    lowest = value[i];
            }
            System.Console.WriteLine("outside loop");
            ans[0] = highest;
            ans[1] = lowest;
            return ans;
        }

        public string GetQuadrant(int x, int y)
        {
            if (x > 0 && y > 0)
                return "Quadrant first";
            else if (x < 0 && y > 0)
                return "Quadrant second";
            else if (x < 0 && y < 0)
                return "Quadrant third";
            else
                return "Quadrant fourth";


        }

        public string GetGradeTotalMark(int[] marks)
        {
            string ans = "";
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            ans = "marks:" + sum;

            int percentage = (sum / 300) * 100;

            if (percentage <= 35)
            {
                ans += " Grade is F";
            }
            else if (percentage >= 34 && percentage <= 39)
            {
                ans += " Grade is D";
            }
            else if (percentage >= 40 && percentage <= 59)
            {
                ans += " Grade is C";
            }
            else if (percentage >= 60 && percentage <= 79)
            {
                ans += " Grade is B";
            }

            else if (percentage >= 80 && percentage <= 90)
            {
                ans += " Grade is A";
            }
            else if (percentage >= 91)
            {
                ans += " Grade is O";
            }

            return ans;

        }
        public string GetTriangle(int[] sides)
        {
            if (sides[0] == sides[1] && sides[1] == sides[2])
                return "EquilateralTraingle";

            else if (sides[0] == sides[1] || sides[1] == sides[2] || sides[2] == sides[1])
                return "Isocles triangle";

            else
                return "Scalene Triangle";
        }

        public string getDigitInstring(int data)
        {
            string ans;
            switch (data)
            {
                case 0:
                    ans = "Zero";
                    break;

                case 1:
                    ans = "One";
                    break;
                case 2:
                    ans = "Two";
                    break;
                case 3:
                    ans = "Three";
                    break;
                case 4:
                    ans = "four";
                    break;
                case 5:
                    ans = "Five";
                    break;
                case 6:
                    ans = "Six";
                    break;
                case 7:
                    ans = "Seven";
                    break;
                case 8:
                    ans = "Eight";
                    break;
                case 9:
                    ans = "Nine";
                    break;
                default:
                    ans = "invalid digits enterd";
                    break;
            }
            return ans;

        }
    }
}