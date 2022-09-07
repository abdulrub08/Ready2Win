using ReadyToWin.Complaince.Framework.Base;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using ReadyToWin.Complaince.Entities.UserTransaction;
using ReadyToWin.Complaince.Entities.AdminModel;
using ReadyToWin.Complaince.BussinessProvider.IProviders;
using ReadyToWin.API.Filters;
using System.Web.Http.Description;
using System.Collections.Generic;
using ReadyToWin.Complaince.Entities.RequestModels;
using ReadyToWin.Complaince.Framework.Utility;
using ReadyToWin.Complaince.Entities.ResponseModel;
using ReadyToWin.Complaince.Entities.Constant;
using System.Data;
using System;
using System.Security.Claims;
using ReadyToWin.API.Models;

namespace ReadyToWin.API.Controllers
{
    [RoutePrefix("api/Admin")]
    public class AdminController : BaseApiController
    {
       IUserTransaction _iUserTransaction;
       IAdminRepository _iAdminRepository;
       public AdminController(IUserTransaction _iUserTransaction, IAdminRepository _iAdminRepository)
       {
           this._iUserTransaction = _iUserTransaction;
           this._iAdminRepository = _iAdminRepository;
       }

       /// <summary>
       /// Select All user amount deposited
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       [CustomAuthorize(Roles = "Admin")]
       [AllowAnonymous]
       [HttpPost]
       [Route("ListOfUserAmountDeposit")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> ListOfUserAmountDeposit(UserAmountDeposit userAmountdeposit)
       {
           var output = _iUserTransaction.ListOfUserAmountDeposit(userAmountdeposit);
           return await CreateResponse(output);
       }       
       [CustomAuthorize(Roles = "Admin, User")]
       [AllowAnonymous]
       [HttpPost]
       [Route("UpdateAmountDeposit")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> UpdateAmountDeposit(UserAmountDeposit userAmountdeposit)
       {
           var output = _iUserTransaction.UpdateAmountDeposit(userAmountdeposit);
           return await CreateResponse(output);
       }

       /// <summary>
       /// List of User withdraw request 
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       [CustomAuthorize(Roles = "Admin")]
       [AllowAnonymous]
       [HttpPost]
       [Route("ListOfUserWithdrawRequest")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> ListOfUserWithdrawRequest(UserAmountWithdraw userAmountwithdraw)
       {
           var output = _iUserTransaction.ListOfUserWithdrawRequest(userAmountwithdraw);
           return await CreateResponse(output);
       }       
       /// <summary>
       /// Update UserWithdraw Request.
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       [CustomAuthorize(Roles = "Admin, User")]
       [AllowAnonymous]
       [HttpPost]
       [Route("UpdateWithdrawRequest")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> UpdateWithdrawRequest(UserAmountWithdraw userAmountwithdraw)
       {
           var output = _iUserTransaction.UpdateWithdrawRequest(userAmountwithdraw);
           return await CreateResponse(output);
       }
       /// <summary>
       /// Update UserWithdraw Request.
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       //[CustomAuthorize(Roles = "Admin")]
       [AllowAnonymous]
       [HttpPost]
       [Route("DeleteWithdrawRequest")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> DeleteWithdrawRequest(UserAmountWithdraw userAmountwithdraw)
       {
           var output = _iUserTransaction.DeleteWithdrawRequest(userAmountwithdraw);
           return await CreateResponse(output);
       }

       /// <summary>
       /// Insert Winning Amount For User
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       [CustomAuthorize(Roles = "Admin")]
       [AllowAnonymous]
       [HttpPost]
       [Route("InsertWinningAmountForUser")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> InsertWinningAmountForUser(Admin insertWinningAmount)
       {
           var output = _iAdminRepository.InsertWinningAmountForUser(insertWinningAmount);
           return await CreateResponse(output);
       }

       /// <summary>
       /// List of winner user
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       [CustomAuthorize(Roles = "Admin")]
       [AllowAnonymous]
       [HttpPost]
       [Route("ListOfWinningUsers")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> ListOfWinningUsers(Admin listofwinnerUser)
       {
           var output = _iAdminRepository.ListOfWinningUsers(listofwinnerUser);
           return await CreateResponse(output);
       }

       /// <summary>
       /// List of winner user by Id
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       [CustomAuthorize(Roles = "Admin")]
       [AllowAnonymous]
       [HttpPost]
       [Route("ListOfWinningUsersById")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> ListOfWinningUsersById(Admin listofwinnerUserbyId)
       {
           var output = _iAdminRepository.ListOfWinningUsersById(listofwinnerUserbyId);
           return await CreateResponse(output);
       }

       /// <summary>
       /// Update Winner User Details 
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       [CustomAuthorize(Roles = "Admin")]
       [AllowAnonymous]
       [HttpPost]
       [Route("UpdateWinningUser")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> UpdateWinningUser(Admin updateWinningUser)
       {
           var output = _iAdminRepository.UpdateWinningUser(updateWinningUser);
           return await CreateResponse(output);
       }

       /// <summary>
       /// Delete Winner User Details 
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       [CustomAuthorize(Roles = "Admin")]
       [AllowAnonymous]
       [HttpPost]
       [Route("DeleteWinningUser")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> DeleteWinningUser(Admin deleteWinningUser)
       {
           var output = _iAdminRepository.DeleteWinningUser(deleteWinningUser);
           return await CreateResponse(output);
       }

       /// <summary>
       /// Delete Winner User Details 
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       [CustomAuthorize(Roles = "Admin")]
       [AllowAnonymous]
       [HttpPost]
       [Route("UserDepositAmountApproved")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> UserDepositAmountApproved(Admin deleteWinningUser)
       {
           var output = _iAdminRepository.UserDepositAmountApproved(deleteWinningUser);
           return await CreateResponse(output);
       }

       /// <summary>
       /// Delete Winner User Details 
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       [CustomAuthorize(Roles = "Admin")]
       [AllowAnonymous]
       [HttpPost]
       [Route("UserWithdrawAmountApproved")]
       [ResponseType(typeof(Response<Admin>))]
       public async Task<HttpResponseMessage> UserWithdrawAmountApproved(Admin deleteWinningUser)
       {
           var output = _iAdminRepository.UserWithdrawAmountApproved(deleteWinningUser);
           return await CreateResponse(output);
       }
    }
}
