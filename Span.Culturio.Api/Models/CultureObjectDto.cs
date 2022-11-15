//using FluentValidation;

namespace Span.FairBank.Api.Models
{
    public class CultureObjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactEmail { get; set; }
        public int ZipCode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int AdminUserId { get; set; }
    }

    //public class BankValidator : AbstractValidator<CultureObjectDto>
    //{
    //    public BankValidator()
    //    {
    //        RuleFor(x => x.Name)
    //            .NotEmpty()
    //            .Length(3, 100);

    //        RuleFor(x => x.Swift)
    //            .NotEmpty()
    //            .Length(8);

    //        RuleFor(x => x.Address)
    //            .NotEmpty()
    //            .Length(5, 100);
    //    }
    //}
}