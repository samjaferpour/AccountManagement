namespace AccountManagement.Contract.Interfaces.Proxy
{
    public interface ISignature
    {
        string Create(string body,string apiAddress);
    }
}