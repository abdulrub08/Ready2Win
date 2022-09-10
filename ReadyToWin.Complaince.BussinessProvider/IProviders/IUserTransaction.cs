using ReadyToWin.Complaince.Entities.Dashboard;
using ReadyToWin.Complaince.Entities.RequestModels;
using ReadyToWin.Complaince.Entities.ResponseModel;
using ReadyToWin.Complaince.Entities.UserTransaction;
using ReadyToWin.Complaince.Framework;
using System.Collections.Generic;
using System.Data;

namespace ReadyToWin.Complaince.BussinessProvider.IProviders
{
    public interface IUserTransaction
    {
        List<UserAmountDeposit> ListOfUserAmountDeposit(UserAmountDeposit userAmountdeposit);
        List<UserAmountDeposit> RecentTransaction(UserAmountDeposit userAmountdeposit);
        List<UserAmountDeposit> ListOfUserAmountDepositByUserId(UserAmountDeposit userAmountdeposit);
        List<UserAmountDeposit> ListOfUserAmountDepositbyId(UserAmountDeposit userAmountdeposit);
        DbOutput AddUserAmountDeposit(UserAmountDeposit Add);
        DbOutput UpdateAmountDeposit(UserAmountDeposit userAmountdeposit);
        DbOutput DeleteAmountDeposit(UserAmountDeposit userAmountdeposit);
        DbOutput ListOfUserWithdrawRequest(UserAmountWithdraw userAmountwithdraw);
        DbOutput ListOfUserWithdrawRequestByUserId(UserAmountWithdraw userAmountwithdraw);
        DbOutput ListOfUserWithdrawRequestbyId(UserAmountWithdraw userAmountwithdraw);
        DbOutput UserWithdrawRequest(UserAmountWithdraw userAmountwithdraw);
        DbOutput UpdateWithdrawRequest(UserAmountWithdraw userAmountwithdraw);
        DbOutput DeleteWithdrawRequest(UserAmountWithdraw userAmountwithdraw);
        int UserGameSelectionSubmit(UserGameSelection userGameSelection);
    }
}
