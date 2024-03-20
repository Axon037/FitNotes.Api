namespace FitNotes.Api.UseCases.User.GetDetails
{
    public class GetUserDetailsModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        //public DateOnly DateOfRegister { get; set; }
    }
}
