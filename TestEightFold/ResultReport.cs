using System;

namespace TestEightFold
{
    public class ShareholderCategory
    {
        public int RptID { get; set; }
        public string ProfileID { get; set; }
        public string Category { get; set; }
        public string CategoryDesc { get; set; }
        public int SortOrder { get; set; }
        public string AcctNo { get; set; }
        public string AcctNoDetail { get; set; }
    }
    public abstract class InvestorBasicInfo
    {
        public string Portfolio { get; set; }
        public string Pool { get; set; }
        public string Investor { get; set; }
        public string SubInvestor { get; set; }

        public string PortfolioDescription { get; set; }
        public string PoolName { get; set; }
        public string InvestorDescription { get; set; }
    }
    public class ReportInvestorStatement : InvestorBasicInfo
    {
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Ccy { get; set; }

        public int FlagOfInvestor { get; set; }

        public int BreakSort { get; set; }
        public string BreakTitle { get; set; }

        public string RowItemKey { get; set; }
        public string DescriptorOfRow { get; set; }
        public string GroupKey { get; set; }

        public decimal? Column1 { get; set; }
        public decimal? Column2 { get; set; }
        public decimal? Column3 { get; set; }

        public string ColumnHeaderDesc1 { get; set; }
        public string ColumnHeaderDesc2 { get; set; }
    }
}
