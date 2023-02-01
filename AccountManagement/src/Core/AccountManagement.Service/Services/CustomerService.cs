using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Interfaces.Proxy;
using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Domain.Entities;

namespace AccountManagement.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IDotinProxy _dotinProxy;

        public CustomerService(ICustomerRepository customerRepository,
                               IDotinProxy dotinProxy)
        {
            _customerRepository = customerRepository;
            _dotinProxy = dotinProxy;
        }
        public async Task Add(AddCustomerRequest request)
        {
            var customer = new Customer
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalCode = request.NationalCode,
                AccountId = request.AccountId,
            };
            await _customerRepository.InsertAsync(customer);
        }
        public async Task<GetCustomerByDemandPacketIdResponse> GetCustomersByDemandPacketId(GetCustomerByDemandPacketIdRequest request)
        {
            var customers =await _customerRepository.FindByAccountId(request.AccountId);
            var result = new GetCustomerByDemandPacketIdResponse();
            foreach (var customer in customers) 
            {
                result.Customers.Add(new CustomerDetial
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    NationalCode = customer.NationalCode,
                });
            };
            return result;
        }
        public async Task<GetCustomerInfoResponse> GetCustomerInfo(GetCustomerInfoRequest request)
        {
            var requset = new GetCustomerInfoRequest
            {
                NationalCode = request.NationalCode
            };
            var customerInfo = await _dotinProxy.GetCustomerInfo(requset);

            //ToDo: اینجا حتما خروجی چک بشه که اگر خروجی موفق نبود تو یه جدول ذخیره بشه
            return customerInfo.Data;
        }
    }
}
