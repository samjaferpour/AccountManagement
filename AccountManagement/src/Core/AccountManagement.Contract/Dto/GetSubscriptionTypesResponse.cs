

namespace AccountManagement.Contract.Dto
{
    public class GetSubscriptionTypesResponse
    {
        public List<SubscriptionTypeItem> SubscriptionTypeItems { get; set; }
    }
    public class SubscriptionTypeItem
    {
        public int Code { get; set; }
        public string Title { get; set; }
    }
}

