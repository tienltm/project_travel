using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class User : IdentityUser<int>
    {
        public UserAddress Address { get; set; }
        //public int CustomerId { get; set; }
        //public int StaffId { get; set; }
    }
}