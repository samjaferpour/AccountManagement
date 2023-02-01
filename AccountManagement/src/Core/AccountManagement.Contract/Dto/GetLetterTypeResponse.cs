

namespace AccountManagement.Contract.Dto
{
    public class GetLetterTypeResponse
    {
        public List<LetterTypeItem> LetterTypeItems { get; set; }
    }

    public class LetterTypeItem
    {
        public int Code { get; set; }
        public string Title { get; set; }
    }

}
