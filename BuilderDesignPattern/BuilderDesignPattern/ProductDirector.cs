using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class ProductDirector
    {
        public ProductReport MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        }

    }
}
