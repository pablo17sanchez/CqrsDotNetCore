using CqrsSample.Commands;
using FluentValidation;

namespace CqrsSample.Validation
{
    public class CreateCustomerOrderCommandValidator : AbstractValidator<CreateCustomerOrderCommand>
    {


        public CreateCustomerOrderCommandValidator()
        {
            RuleFor(x => x.CustomerId)
                .NotEmpty();

            RuleFor(x => x.ProductId)
                .NotEmpty();
        }
    }
}
