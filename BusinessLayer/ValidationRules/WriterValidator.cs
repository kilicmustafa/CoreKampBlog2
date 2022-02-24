using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator :AbstractValidator<Writer>
    {


        public WriterValidator()
        {

            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Please write a writer name!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Plase write an email adress!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Please create a password !");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Name must be contein minimun 2 character !");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Name can be max 50 character length! ");
            







        }



    }
}
