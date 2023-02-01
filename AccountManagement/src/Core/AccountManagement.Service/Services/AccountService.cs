using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Interfaces.Proxy;
using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Domain.Entities;


namespace AccountManagement.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IDotinProxy _dotinProxy;

        public AccountService(IAccountRepository accountRepository,
                              IDotinProxy dotinProxy)
        {
            _accountRepository = accountRepository;
            _dotinProxy = dotinProxy;
        }
        #region Public Methods
        public async Task<Guid> Add(AddAccountRequest request)
        {
            var account = new Account
            {
                Number = request.Number,
                Iban = request.Iban,
                AvailableAmount = request.AvailableAmount,
                ActualAmount = request.ActualAmount,
                DemandPacketId = request.DemandPacketId,
                TypeDescription= request.TypeDescription,
            };
            var accountId = await _accountRepository.InsertAsync(account);
            return accountId;
        }
        public async Task<GetAccountOwnershipTypeResponse> GetAccountOwnershipTypes()
        {
            var accountTypes = await _accountRepository.AccountOwnershipTypeAsync();
            List<AccountOwnershipTypeItem> AccountOwnershipTypeItems = new List<AccountOwnershipTypeItem>();
            GetAccountOwnershipTypeResponse response = new GetAccountOwnershipTypeResponse();

            foreach (var item in accountTypes)
            {
                AccountOwnershipTypeItems.Add(new AccountOwnershipTypeItem { Code = item.Id, Title = item.Title });
            }
            response.AccountOwnershipTypeItems = AccountOwnershipTypeItems;

            return response;
        }


        public async Task<GetSubscriptionTypesResponse> GetSubscriptionTypes()
        {
            var subscriptionData = await _accountRepository.GetSubscriptionTypeAsync();
            List<SubscriptionTypeItem> SubscriptionTypeItems = new List<SubscriptionTypeItem>();
            GetSubscriptionTypesResponse answer = new GetSubscriptionTypesResponse();

            foreach (var item in subscriptionData)
            {
                SubscriptionTypeItems.Add(new SubscriptionTypeItem { Code = item.Id, Title = item.Title });
            }
            answer.SubscriptionTypeItems = SubscriptionTypeItems;
            return answer;
        }


        public async Task<GetAccountByDemandPacketIdResponse> GetAccountsByDemandPacketId(GetAccountByDemandPacketIdRequest request)
        {
            var accounts = await _accountRepository.GetAccountsByDemandPacketId(request.DemandPacketId);

            var result = new GetAccountByDemandPacketIdResponse();
            foreach (var account in accounts)
            {
                result.Accounts.Add(new AccountDetail
                {
                    Id = account.Id,
                    Number = account.Number,
                    Iban = account.Iban,
                    ActualAmount = account.ActualAmount,
                    AvailableAmount = account.AvailableAmount,
                });
            };
            return result;
        }
        public async Task<GetCustomerAccountsResponse> GetCustomerAccounts(GetCustomerAccountsRequest request)
        {
            var customerAccounts = await GetCustomerAccountsProxy(request);
            return GenerateResponse(customerAccounts);
        }
        public async Task<GetAccountInfoResponse> GetAccountInfo(GetAccountInfoRequest request)
        {
            var accountInfo = await GetAccountInfoProxy(request);
            return GenerateResponse(accountInfo);
        }

        public async Task<GetSwiftTypesResponse> GetSwiftTypes()
        {
            var swiftTypes = await _accountRepository.GetSwiftTypesAsync();
            List<SwiftTypeItem> swiftTypeItems = new List<SwiftTypeItem>();
            GetSwiftTypesResponse result = new GetSwiftTypesResponse();

            foreach (var swiftType in swiftTypes)
            {
                swiftTypeItems.Add(new SwiftTypeItem { Code = swiftType.Id, Title = swiftType.Title });
            }
            result.SwiftTypeItems = swiftTypeItems;
            return result;
        }
        #endregion

        #region Private Methods
        private async Task<GetAccountInfoProxyResponse> GetAccountInfoProxy(GetAccountInfoRequest request)
        {
            var requset = new GetAccountInfoProxyRequest
            {
                DepositNumberOrIBAN = request.AccoutnNumberOrIBAN
            };
            var customerInfo = await _dotinProxy.GetAccountInfo(requset);

            //ToDo: اینجا حتما خروجی چک بشه که اگر خروجی موفق نبود تو یه جدول ذخیره بشه
            return customerInfo.Data;
        }
        private GetCustomerAccountsResponse GenerateResponse(GetCustomerAccountsProxyResponse customerAccounts)
        {
            var response = new GetCustomerAccountsResponse();
            var accounts = new List<CustomerAccount>();
            foreach (var account in customerAccounts.Accounts)
            {
                accounts.Add(new CustomerAccount
                {
                    AccountNumber = account.AccountNumber,
                    AccountIban = account.AccountIban,
                    AccountState = account.AccountState,
                    AccountTypeTitle = account.AccountTypeTitle,
                    CreatorBranchCode = account.CreatorBranchCode,
                    OpeningDate = account.OpeningDate,
                    WithdrawRight = account.WithdrawRight,
                    SubscriptionType = account.SubscriptionType,
                });
            }
            response.Accounts = accounts;
            return response;
        }
        private GetAccountInfoResponse GenerateResponse(GetAccountInfoProxyResponse accountInfo)
        {
            var customers = new List<CustomerInfo>();
            var response = new GetAccountInfoResponse
            {
                ActualAmount = accountInfo.ActualAmount,
                AvailableAmount = accountInfo.AvailableAmount,
                BackupAccountNumber = accountInfo.BackupAccountNumber,
                CreatorBranchCode = accountInfo.CreatorBranchCode,
                Iban = accountInfo.Iban,
                Number = accountInfo.Number,
                OwnershipTypeId = accountInfo.OwnershipTypeId,
                TypeDescription = accountInfo.TypeDescription,
                CreateDate = accountInfo.CreateDate,
                SharePercent = accountInfo.SharePercent,
                Status = accountInfo.Status,
            };
            foreach (var customer in accountInfo.CustomerInfoProxys)
            {
                var customerInfo = new CustomerInfo
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    NationalCode = customer.NationalCode,
                    CustomerType = customer.CustomerType
                };
                customers.Add(customerInfo);
            }
            response.CustomerInfos= customers;
            return response;
        }
        private async Task<GetCustomerAccountsProxyResponse> GetCustomerAccountsProxy(GetCustomerAccountsRequest request)
        {
            var customerAccountRequest = new GetCustomerAccountsProxyRequest
            {
                NationalCode = request.NationalCode,
            };
            var customerAccounts = await _dotinProxy.GetCustomerAccounts(customerAccountRequest);

            //ToDo: اینجا حتما خروجی چک بشه که اگر خروجی موفق نبود تو یه جدول ذخیره بشه
            return customerAccounts.Data;
        }
        #endregion

    }
}
