using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Business.ValidationRules;
using FluentValidation;
using System.IO;

namespace Business.Concrete
{


    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            
            _userDal.Add(user);
        }

        public User Authenticate(User user)
        {
            UserValidator userValidator = new UserValidator();
            var result = userValidator.Validate(user);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }

            var existingUser = _userDal.GetAll().FirstOrDefault(u => u.UserName == user.UserName && u.UserPassword == user.UserPassword);
            if (existingUser == null)
            {
                throw new Exception("Kullanıcı bulunamadı veya şifre yanlış.");
            }

            
            if (existingUser.UserType == 1)
            {
                throw new Exception("Login1"); // Type 1 user
                
            }
            else
            {
                throw new Exception("Login2"); // Type 2 user 
                
            }


        }

       

        public void Delete(User user)
        {
            try
            {
                _userDal.Delete(user);
            }
            catch
            {

                throw new Exception("Silme gerçekleşemedi");

            }
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        
    }
}
