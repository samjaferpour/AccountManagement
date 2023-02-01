

namespace AccountManagement.Contract.Dto
{
    public class GetSwiftTypesResponse
    {
        public List<SwiftTypeItem> SwiftTypeItems { get; set; }
    }
    public class SwiftTypeItem
    {
        public int Code { get; set; }
        public string Title { get; set; }
    }
}

