using System.Security.Cryptography;
using System.Text;
using AccountManagement.Contract.Dto.Setting;
using AccountManagement.Contract.Interfaces.Proxy;
using Microsoft.Extensions.Options;

namespace AccountManagement.ServicesProxy.Implementation.DotinProxy.Implementation
{
    public class Signature : ISignature
    {
        private readonly SiteSetting _siteSetting;

        public Signature(IOptions<SiteSetting> options)
        {
            _siteSetting = options.Value;
        }
        const string SHARP_SEPARATOR = "#";
        public string Create(string body,string apiAddress)
        {
            ASCIIEncoding ByteConverter = new ASCIIEncoding();
            string plainText = preparePlainText(body, apiAddress);
            byte[] originalData = Encoding.UTF8.GetBytes(plainText);
            byte[] signedData;
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            string privateKey = _siteSetting.DotinConfig.PrivateKey;
            rsaCSP.FromXmlString(privateKey);
            signedData = rsaCSP.SignData(originalData, SHA1.Create());
            string base64String = Convert.ToBase64String(signedData, 0, signedData.Length);
            return base64String;
        }
        private string preparePlainText(string body,string apiAddress)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("POST");
            sb.Append(SHARP_SEPARATOR);
            sb.Append(apiAddress);
            sb.Append(SHARP_SEPARATOR);
            sb.Append(_siteSetting.DotinConfig.ApiKey);
            sb.Append(SHARP_SEPARATOR);
            sb.Append(body);
            return sb.ToString();
        }
    }
}
