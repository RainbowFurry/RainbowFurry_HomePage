using JasonJT_Web.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace JasonJT_Web.Database.Model
{
    public class AccountDBModel
    {

        public List<Account> listAccounts = new List<Account>();

        public AccountDBModel()
        {
            listAccounts = MongoDBManager.Instance.GetDatabase().GetCollection<Account>("JasonJT_Users").Find<Account>(new BsonDocument()).ToList();
        }

        public void UpdateAccountList()
        {
            listAccounts = MongoDBManager.Instance.GetDatabase().GetCollection<Account>("JasonJT_Users").Find<Account>(new BsonDocument()).ToList();
        }

        public Account Find(string userID)
        {
            return listAccounts.Where(acc => acc.UserID.Equals(userID)).FirstOrDefault();
        }

        public Account Login(string identifier, string password)
        {
            UpdateAccountList();
            Account user = listAccounts.Where(acc => acc.NickName.Equals(identifier) && acc.Password.Equals(password)).FirstOrDefault();
            if (user == null)
                user = listAccounts.Where(acc => acc.Email.Equals(identifier) && acc.Password.Equals(password)).FirstOrDefault();
            return user;
        }

    }
}