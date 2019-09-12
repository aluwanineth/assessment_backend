using FluentValidation;
using ParkRunners.Api.Models.Requests.MenuItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkRunners.Api.Models.Validations
{
    public class CreateMenuItemValidator : AbstractValidator<CreateMenuItemRequest>
    {
        public CreateMenuItemValidator()
        {
            RuleFor(x => x.DisplayOrder).NotNull().IsInEnum();
            RuleFor(x => x.Label).NotNull().Length(1, 20).NotNull();
            RuleFor(x => x.ClientSideId).NotNull().IsInEnum(); ;
        }
    }
}