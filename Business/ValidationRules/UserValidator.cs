using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage("Kullanıcı adı boş olamaz:")
                .MinimumLength(5).WithMessage("Kullanıcı adı 5 karakterden uzun olmalı");

            RuleFor(p => p.UserPassword)
                .NotEmpty().WithMessage("Şifre Boş olamaz.")
                .MinimumLength(6).WithMessage("Şifre 6 karakterden az olamaz ");
        }
    }
}
