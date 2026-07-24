using BilliardsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using Shared;
using BilliardsDataAccessLayer.DTOs;
namespace BilliardsBusinessLayer
{
    class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; private set; } = enMode.AddNew;

        public int? UserID { get; private set; }
        public int PersonID { get; private set; }
        public clsPerson? PersonInfo { get; private set; }
        public string UserName { get; set; }
        public string Password { get; private set; }
        public bool IsActive { get; set; }
        public clsUser(int personID, string userName, string password, bool isActive)
        {
            UserID = null;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Mode = enMode.AddNew;
        }
        //public clsUser()
        //{
        //    UserID = null;
        //    PersonID = -1;
        //    PersonInfo = null;
        //    UserName = "";
        //    Password = "";
        //    IsActive = true;
        //    Mode = enMode.AddNew;
        //}
        private  clsUser(UserDTO User)
        {
            this.UserID =   User.UserID;
            this.PersonID = User.PersonID;
            this.UserName = User.UserName;
            this.Password = User.Password;
            this.IsActive = User.IsActive;
            Mode = enMode.Update;

        }

        public static async Task<clsUser?> FindByUserIDAsync(int UserID)
        {
            UserDTO? user = await clsUsersData.GetUserInfoByUserIDAsync(UserID);

            if(user !=  null)
            {
                clsUser UserFound = new clsUser(user);
                UserFound.PersonInfo = await clsPerson.FindAsync(UserFound.PersonID);
                return UserFound;
            }
 
            return null;
        }
      
        public static async Task<clsUser?> FindByUserNameAndPasswordAsync(string UserName, string Password)
        {
            if (string.IsNullOrWhiteSpace(Password))
                return null;
            Password = clsCryptography.ComputeHash(Password);

            UserDTO? user = await clsUsersData.GetUserInfoUserNameAndPasswordAsync(UserName,Password);

            if (user != null)
            {
                clsUser UserFound = new clsUser(user);
                UserFound.PersonInfo = await clsPerson.FindAsync(UserFound.PersonID);
                return UserFound;
            }

            return null;
        }
        private async Task<bool> _AddNewUserAsync()
        {
            if (string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(UserName))
                return false;

            string hashedPassword = clsCryptography.ComputeHash(this.Password);
            int? ID = await clsUsersData.AddNewUserAsync(new UserDTO { UserName = this.UserName,Password = hashedPassword, PersonID =this.PersonID,IsActive =this.IsActive});
            if (ID == null)
                return false;
            this.UserID = ID.Value;
            this.PersonInfo = await clsPerson.FindAsync(this.PersonID);
            return true;
        }
        private Task<bool> _UpdateUser()
        {
            if (UserID == null)
                return Task.FromResult(false);
            return clsUsersData.UpdateUserAsync(new UserDTO { UserID = this.UserID.Value, PersonID = this.PersonID, UserName = this.UserName, IsActive = this.IsActive });
        }
        public async Task<bool> SaveAsync()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewUserAsync())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return await _UpdateUser();

            }

            return false;
        }
        public async Task<bool> ChangePasswordAsync(string NewPassword)
        {
            if (UserID == null)
                return false;

            if (string.IsNullOrWhiteSpace(NewPassword))
                return false;

            NewPassword = clsCryptography.ComputeHash(NewPassword);

            if (await clsUsersData.ChangePasswordAsync(this.UserID.Value, NewPassword))
            {
                this.Password = NewPassword;
                return true;
            }
            return false;

        }

        public static Task<DataTable> GetAllUsersAsync()
        {
            return  clsUsersData.GetAllUsersAsync();
        }
        public static Task<bool> DeleteUserAsync(int UserID)
        {
            if(UserID <= 0)
                return Task.FromResult(false);
            return clsUsersData.DeleteUserAsync(UserID);
        }
        public static Task<bool> IsUserExistByUserIDAsync(int UserID)
        {
            return clsUsersData.IsUserExistByUserIDAsync(UserID);
        }
        public static Task<bool> IsUserExistByUserNameAsync(string UserName)
        {
            return clsUsersData.IsUserExistByUserNameAsync(UserName);
        }
        public static Task<bool> IsUserExistForPersonIDAsync(int PersonID)
        {
            return clsUsersData.IsUserExistForPersonIDAsync(PersonID);
        }
    }
}
