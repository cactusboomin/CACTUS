using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Service
{
    public interface ILanguageService
    {
        #region ACCOUNT

        static string SignIn;
        static string SignUp;

        static string EnterUserName;
        static string UserName;

        static string EnterEmail;
        static string Email;

        static string EnterPassword;
        static string Password;

        static string ConfirmPassword;
        static string PasswordsAreNotSame;

        static string RememberMe;

        static string FalsePasswordOrLogin;
        
        static string UserWithEmail;
        static string AlreadyExists;

        static string EnterNewEmail;
        static string NewEmail;

        static string EnterNewUserName;
        static string NewUserName;

        static string EnterNewPassword;
        static string NewPassword;
        static string ConfirmNewPassword;

        #endregion

        #region COLLECTIONS

        static string ChooseNewPhoto;

        static string Title;
        static string Theme;
        static string TitleImage;
        static string TimeAdded;

        static string NewTitle;
        static string NewTitleImage;
        static string NewDescription;
        static string NewTheme;

        static string CreateItem;
        static string EditCollection;
        static string DeleteCollection;

        static string Creator;

        static string CreateCollection;
        static string Create;

        static string EditTitle;
        static string EditTitleImage;
        static string EditDescription;
        static string EditTheme;

        static string Edit;

        #endregion

        #region HOME

        static string CACTUS;
        static string Light;
        static string Dark;

        static string GetInTouch;
        static string Name;
        static string Message;
        static string Send;
        static string AllRightsReserved;

        static string Menu;

        static string MyPage;
        static string Home;
        static string Users;
        static string Favourites;
        static string Settings;
        static string Exit;

        static string Search;
        static string Find;

        static string SortBy;
        static string Date;

        static string Collections;
        static string Items;
        static string Tags;

        #endregion

        #region ITEMS

        static string EditItem;

        static string Like;
        static string Dislike;

        static string DeleteItem;

        static string Collection;


        #endregion

        #region TAGS

        static string Tag;
        static string InputNameOfTheTag;

        static string AddTag;
        static string Add;

        #endregion

        #region USER

        static string ChangeEmail;
        static string SaveChanges;

        static string ChangeName;

        static string ChangePassword;

        static string YourFavouriteItems;
        
        static string sPage;

        static string GiveAdminRoots;
        static string DeleteUser;



        #endregion

        #region THEMES

        static List<string> Themes;

        #endregion
    }
}
