﻿namespace Secure_API_Template.Data.Entites
{
    public class AppUsers
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required byte[] PasswordHash { get; set; }
        public required byte[] PasswordSalt { get; set; }
        //public required string Role { get; set; }
        //public required string Email { get; set; }
        //public required string Mobile { get; set; }
        //public required string Address { get; set; }
        //public required string FullName { get; set; }
        //public required string Gender { get; set; }
        //public required string Status { get; set; }
        //public required DateTime CreatedOn { get; set; }
        //public required int CreatedBy { get; set; }
        //public DateTime? UpdatedOn { get; set; }
        //public int? UpdatedBy { get; set; }
        //public bool IsDeleted { get; set; }
        //public DateTime? DeletedOn { get; set; }
        //public int? DeletedBy { get; set; }
        //public DateTime? LockedOn { get; set; }
        //public int? LockedBy { get; set; }
        //public bool IsLocked { get; set; }
    }
}
