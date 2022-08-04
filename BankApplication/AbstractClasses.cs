namespace AbstractNameSpace
{
    class Shape
    {
        string name;
        int perimeter;
        int area;
        public Shape()
        {

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Perimeter
        {
            get { return perimeter; }
            set { perimeter = value; }
        }
        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public abstract double calculateArea();

        public abstract double calculatePerimeter();

        public abstract string draw();
    }
    class Rectangle : Shape
    {
        double width;
        double height;

        public double Width { get; set; }
        public double Height { get; set; }

        public override double calculateArea()
        {
            return width * height;
        }
        public override double calculatePerimeter()
        {
            return 2*(width+height);
        }
        public override string draw()
        {
            return "Rectangle drawn";
        }

    }

    class Square : Shape
    {
    double side;

        public double Side { get; set; }//getters and setters
        

        public override double calculateArea()
        {
            return side * side;
        }
        public override double calculatePerimeter()
        {
            return 2 * (side + side);
        }
        public override string draw()
        {
            return "Square drawn";
        }

    }
    class Circle : Shape
    {
    double radius;

        public double Radius { get; set; }


        public override double calculateArea()
        {
            return 3.14 * radius * radius;
        }
        public override double calculatePerimeter()
        {
            return 2*3.14 * (radius + radius);
        }
        public override string draw()
        {
            return "Circle drawn";
        }

    }
}