using FluentValidation;
using MatrimonialApi.Models;

/// <summary>
/// 
/// </summary>
public class UserDTOValidator : AbstractValidator<UserDTO>
{
    /// <summary>
    /// UserDTO validator
    /// </summary>
    public UserDTOValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(x => x.Role)
            .NotEmpty().WithMessage("Role is required.");
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("First name is required.");
        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Last name is required.");
        RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("User name is required.");
            // Add other validation rules as needed
    }
}
