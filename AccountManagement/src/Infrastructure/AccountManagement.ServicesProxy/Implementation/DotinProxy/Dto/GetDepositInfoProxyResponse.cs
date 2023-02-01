namespace AccountManagement.ServicesProxy.Implementation.DotinProxy.Dto
{
    public class GetDepositInfoProxyResponse
    {
        public bool IsSuccess { get; set; }
        public int RsCode { get; set; }
        public string Message { get; set; }
        public ResultData ResultData { get; set; }
    }
    public class AccountOwnershipType
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class AccountStatus
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class AccountType
    {
        public int Code { get; set; }
        public string Description { get; set; }
    }

    public class CustomerList
    {
        public string CustomerType { get; set; }
        public string Address { get; set; }
        public string CustomerId { get; set; }
        public string PostCode { get; set; }
        public object State { get; set; }
        public string ValidateCustomer { get; set; }
        public string CellphoneNo { get; set; }
        public object Email { get; set; }
        public string AddressType { get; set; }
        public string ProvinceCode { get; set; }
        public string CityName { get; set; }
        public string EparchyCode { get; set; }
        public string Cid { get; set; }
        public string ApproveDate { get; set; }
        public string ApproveType { get; set; }
        public string CreateBranchCode { get; set; }
        public string CreateDate { get; set; }
        public string CreateTime { get; set; }
        public string CellphoneNumber { get; set; }
        public string Shahab { get; set; }
        public object NameDescPe { get; set; }
        public object CompanyActivity { get; set; }
        public object CompanyType { get; set; }
        public object NationalId { get; set; }
        public object RegisterDate { get; set; }
        public object RegisterNumber { get; set; }
        public object RegisterLocation { get; set; }
        public object RegisterCountry { get; set; }
        public object UniversalId { get; set; }
        public object Name { get; set; }
        public string NationalCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string DeathStatus { get; set; }
        public string DegreeType { get; set; }
        public string FatherName { get; set; }
        public string GenderType { get; set; }
        public string IdentificationNumber { get; set; }
        public string MarriageType { get; set; }
        public string BirthCityCode { get; set; }
        public string BirthCityName { get; set; }
        public string BirthCertificateSerialNumber { get; set; }
        public string SerialNumber { get; set; }
        public string SeriNumber { get; set; }
        public object IdentificationDocumentIssueDate { get; set; }
        public object IdentificationDocumentExpirationDate { get; set; }
        public object IdentificationDocumentNumber { get; set; }
        public object IdentificationDocumentType { get; set; }
        public object BirthCountry { get; set; }
        public string Nationality { get; set; }
        public object LatinFirstName { get; set; }
        public object LatinLastName { get; set; }
    }

    public class CustomerPortion
    {
        public string CustomerNumber { get; set; }
        public int Portion { get; set; }
    }

    public class ResultData
    {
        public string AccountNum { get; set; }
        public string Iban { get; set; }
        public string CreateDate { get; set; }
        public string LastChangeDate { get; set; }
        public double BesAmount { get; set; }
        public double BedAmount { get; set; }
        public double BlockAmount { get; set; }
        public string BlockDate { get; set; }
        public string StampCount { get; set; }
        public string SignCount { get; set; }
        public string SignDescription { get; set; }
        public string CreateBranchCode { get; set; }
        public RightOfWithdrawalType RightOfWithdrawalType { get; set; }
        public double ActualAmount { get; set; }
        public double AvailableAmount { get; set; }
        public string TrusteeBranchCode { get; set; }
        public AccountType AccountType { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public AccountOwnershipType AccountOwnershipType { get; set; }
        public List<CustomerList> CustomerList { get; set; }
        public List<CustomerPortion> CustomerPortions { get; set; }
    }

    public class RightOfWithdrawalType
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }




}
