

namespace AccountManagement.Contract.Dto
{
    public class GetAccountOwnershipTypeResponse
    {
        public List<AccountOwnershipTypeItem> AccountOwnershipTypeItems { get; set; }
    }
    public class AccountOwnershipTypeItem
    {
        public int Code { get; set; }
        public string Title { get; set; }
    }

}

 