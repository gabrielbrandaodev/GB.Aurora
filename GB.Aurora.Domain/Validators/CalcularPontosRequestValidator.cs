using FluentValidation;
using GB.Aurora.Domain.Arguments;
using System.Linq;

namespace GB.Aurora.Domain.Validators
{
    public class CalcularPontosRequestValidator : AbstractValidator<CalcularPontosRequest>
    {
        private readonly string _message = "Preencha corretamente os valores dos dados.";

        public CalcularPontosRequestValidator()
        {
            RuleFor(x => x.ValoresDados)
                .NotEmpty().WithMessage(_message)
                .NotNull().WithMessage(_message);

            RuleFor(x => x)
                .Must(ValidarRequest).WithMessage(_message);
        }

        private bool ValidarRequest(CalcularPontosRequest request)
        {
            if (request.ValoresDados.Count() != 5)
                return false;

            return true;
        }
    }
}
