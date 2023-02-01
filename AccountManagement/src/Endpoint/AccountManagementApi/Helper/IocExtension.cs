using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Dto.Setting;
using AccountManagement.Contract.Interfaces.Proxy;
using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Framework.RabitMQ;
using Microsoft.Extensions.Options;
using AccountManagement.Service.Services;
using AccountManagement.ServicesProxy.Implementation.DotinProxy.Implementation;
using AccountManagement.Persistence.Implimentation;
using AccountManagement.Persistence.Implimentation.Repositories;
using AccountManagementApi.FluentValidators;
using FluentValidation;
namespace AccountManagementApi.Helper
{
    public static class IocExtension
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ILetterService, LetterService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<IDemandPacketService, DemandPacketService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IAccountManagementService, AccountManagementService>();
            services.AddScoped<IBlockAccountTransactionService, BlockAccountTransactionService>();
            services.AddScoped<IWithdrawAccountTransactionService, WithdrawAccountTransactionService>();
        }
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ILetterRepository, LetterRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IDemandPacketRepository, DemandPacketRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IBlockUnblockReasonRepository, BlockUnblockReasonRepository>();
            services.AddScoped<IBlockAccountTransactionRepository, BlockAccountTransactionRepository>();
            services.AddScoped<IWithdrawAccountTransactionRepository, WithdrawAccountTransactionRepository>();
        }

        public static void AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void AddInfra(this IServiceCollection services)
        {
            services.AddScoped<IDotinProxy, DotinProxy>();
            services.AddScoped<ISignature, Signature>();

        }
        public static void AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<GenerateTrackingCodeRequest>, GenerateTrackingCodeRequestValidator>();
        }
        public static void AddFreamwork(this IServiceCollection services)
        {
            services.AddTransient<IQueueProducer, RabitMQProducer>();
        }
        public static void AddHttpClientFactory(this IServiceCollection services)
        {
            var sp = services.BuildServiceProvider();
            var siteSetting = sp.GetService<IOptions<SiteSetting>>().Value;

            services.AddHttpClient("ebanksepah", c =>
            {
                c.BaseAddress = new Uri(siteSetting.DotinConfig.ServiceUrl);
                c.Timeout = TimeSpan.FromSeconds(100);
            });
        }
    }
}
