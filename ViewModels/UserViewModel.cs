using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotoAwards.Models;
using PhotoAwards.Repository.Users;

namespace PhotoAwards.ViewModels
{
    public class UserViewModel:BaseViewModel
    {
        #region Private Variables 
        public IUser _repo {get; set;}
        #endregion
        public UserViewModel(IUser repo)
        {
            this._repo=repo;
        }
    
        // public async Task<ResultModel<UserModel>> RegisterUser(UserModel data)
        // {
        //     data.ID= Guid.NewGuid();
        //     data.Password = AppHelper.Instance.GetHash(data.Password); 
        //     var result =this._repo.Add(data);
        //     return await result;
        // }
        // public async Task<UserModel> UpdateUser(Guid id,UserModel data)
        // {
        //     data.ID = id;
        //     var result = this._repo.Update(data);
        //     return await result;
        // }
        // public async Task<UserModel> DeleteUser(string id)
        // {
        //     return await this._repo.Remove(id);
        // }
        // public async Task<List<UserModel>> GetUsers()
        // {     
        //     return await this._repo.GetAll() as List<UserModel>;
        // }
        // public async Task<UserModel> GetUserById(Guid id)
        // {     
        //     return await this._repo.Find(id.ToString());
        // }
        // public async Task<LoginModel> Login(LoginModel data)
        // {
            
        //     if (!string.IsNullOrEmpty(data.Email) &&
        //    !string.IsNullOrEmpty(data.Password))
        //     {
        //         var user = await this._repo.GetByEmailOrNumber(data.Email);
        //         Console.WriteLine("Email is " +user.Name);
        //         Console.WriteLine("Password is " + user.Password);

        //         data.Password = AppHelper.Instance.GetHash(data.Password);
        //         Console.WriteLine(data.Password);
        //         if (user != null)
        //         {
        //             if(data.Password == user.Password)
        //             {    
        //                 Console.WriteLine("Name is" +data.Name);
        //                 data.Username = user.Username;
        //                 data.Name = user.Name;
        //                 data.Email = user.Email;
        //                 data.PhoneNo = user.PhoneNo;
        //                 data.Token = new JwtTokenBuilder()
        //                                                 .AddSecurityKey(JwtSecurityKey.Create(JwtSecurityKey.SecretKey))
        //                                                 .AddSubject(user.Email)
        //                                                 .AddIssuer("Security.Bearer")
        //                                                 .AddAudience("Security.Bearer")
        //                                                 .AddClaim("IsAdmin", "true")
        //                                                 .AddClaim("Id",user.ID.ToString())
        //                                                 .AddExpiry(720)
        //                                                 .Build();
                       
        //             }

        //             else{
        //                 data.Token = "wrong password";
        //             }
                  
        //         }
            
        //     }
        //     data.Password = null;
        //     return data;
        // } 
        // public async Task<string> ForgetPassword(string email){
        //    var result = await this._repo.GetByEmailOrNumber(email);
        //     if(result!=null)
        //     {
        //         result.Otp= base.GenerateTicketNumber().Substring(8);
        //         await this._repo.Update(result);
        //         this.SendForgetPasswordMail(email,result.Otp);
        //         return "Otp sent over email";
        //     }
        //     else {
        //         return "Inavalid Email";
        //     }
        // }
        // public async Task<LoginModel> ChangePassword(Guid Id,ChangePasswordModel data){
        //     data.UserId = Id;
        //     var user = await this._repo.Find(data.UserId.ToString());
        //     var result = new LoginModel();
        //     if (user != null)
        //     {
        //         result.Password = data.NewPassword;
        //         result.Username = user.Email;
        //         if (data.NewPassword == data.ConfirmPassword)
        //         {
        //             user.Password = AppHelper.Instance.GetHash(data.NewPassword);
        //             await this._repo.Update(user);
        //             return await this.Login(result);
        //         }
        //         else
        //         {
        //             result.Token = "Password didnot match";
        //         }
        //     }
        //     return result;
        // }
        // public async Task<string> VerifyOtp(ChangePasswordModel data){

        //      var user = await this._repo.Find(data.UserId.ToString());
        //      if(user.Otp==data.Otp)
        //      {
        //          return "Otp Verified";
        //      }
        //      return "Wrong Otp";
        // }


        // #region Private Methods
        // private void SendForgetPasswordMail(string email,string otp)
        // {
        //     string subject="Forget Password OTP";
        //     string body=otp;
        //     EmailHelper.SendMail(email,body,subject);
        // }
        // #endregion
    }
}