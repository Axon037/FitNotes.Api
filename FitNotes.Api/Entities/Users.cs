﻿namespace FitNotes.Api.Entities
{
    public class Users
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //public DateOnly DateOfRegister { get; set; }
    }
}
