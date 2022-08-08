namespace BuilderDesignPattern
{
    class Driver
    {
        static void Main(string[] args)
        {
            ProductReport report;
            ProductDirector director = new ProductDirector();
            ExcelConcreteBuilder builder = new ExcelConcreteBuilder();
            report = director.MakeReport(builder);
            report.DisplayReport();

        }
    }
}