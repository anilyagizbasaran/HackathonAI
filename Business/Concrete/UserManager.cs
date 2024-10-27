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

namespace Business.Concrete
{


    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Authenticate(User user)
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

            // Kullanıcı türüne göre özel mesaj fırlatılıyor
            if (existingUser.UserType == 1)
            {
                throw new Exception("Login1"); // Tür 1 kullanıcı
            }
            else
            {
                throw new Exception("Login2"); // Tür 2 kullanıcı
            }


        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }


    }
}
