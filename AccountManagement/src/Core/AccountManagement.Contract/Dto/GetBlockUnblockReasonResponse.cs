

namespace AccountManagement.Contract.Dto
{
    public class GetBlockUnblockReasonResponse
    {
       public List<BlockUnblockReasonItem> BlockUnblockReasonItems { get; set; }    
    }
    public class BlockUnblockReasonItem
    {
        public int Code { get; set; }
        public string Title { get; set; }
    }
}
