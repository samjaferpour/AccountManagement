using AccountManagement.Persistence.EntityConfigs;

using Microsoft.EntityFrameworkCore;


namespace AccountManagement.Persistence.Implimentation
{
    public static class AccountManagementDbContextHelpers
    {
        public static void EntityConfigurations(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LetterConfigs());
            modelBuilder.ApplyConfiguration(new AccountConfigs());
            modelBuilder.ApplyConfiguration(new CustomerConfigs());
            modelBuilder.ApplyConfiguration(new DemandPacketConfigs());
            modelBuilder.ApplyConfiguration(new TransactionConfigs());;
            modelBuilder.ApplyConfiguration(new AccountOwnershipTypeConfig());
            modelBuilder.ApplyConfiguration(new BlockUnblockReasonTypeConfig());
            modelBuilder.ApplyConfiguration(new DemandStatusConfig());
            modelBuilder.ApplyConfiguration(new LetterTypeConfig());
            modelBuilder.ApplyConfiguration(new SubscriptionTypeConfig());
            

           
            modelBuilder.ApplyConfiguration(new BlockAccountTransactionConfigs());
            modelBuilder.ApplyConfiguration(new WithdrawAccountTransactionConfigs());
            modelBuilder.ApplyConfiguration(new SwiftTypeConfig());
            modelBuilder.ApplyConfiguration(new DemandPacketAccountOwnershipTypeConfigs());
            modelBuilder.ApplyConfiguration(new DemandPacketSubscriptionTypeConfigs());
        }
    }
}
