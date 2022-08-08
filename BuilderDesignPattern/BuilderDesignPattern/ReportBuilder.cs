using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal abstract class ReportBuilder
    {
        protected ProductReport reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            reportObject = new ProductReport();
        }
        public ProductReport GetReport()
        {
            return reportObject;
        }
    }
}
