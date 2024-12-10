using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator :AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("ürünün adi boş olamaz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("ürünün adi 3 krekterden az olamaz");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("stock mıktarı boş olamaz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("ürünün fiyat boş boş olamaz");
      
        }
    }
}
