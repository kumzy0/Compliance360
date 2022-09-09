using System;

namespace Compliance360.Models
{
  public class UserAuth : BaseClass
  {
    public string Id { get; set; }
    public string UserId { get; set; }
    public virtual ApplicationIdentity User { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string OTP { get; set; }
    public bool IsEmailConfirmed { get; set; }
    public DateTime LastGenerated { get; set; }
    public string Others { get; set; }

  }
}
