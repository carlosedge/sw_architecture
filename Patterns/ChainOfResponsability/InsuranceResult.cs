namespace ChainOfResponsability
{
    public class InsuranceResult
    {
        public bool HasInsurance { get; internal set; }
        public decimal Amount { get; internal set; }
        public decimal Franchise { get; internal set; }
        public InsuranceType Type{ get; internal set; }
    }
}
