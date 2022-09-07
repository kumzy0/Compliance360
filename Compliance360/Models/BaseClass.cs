using System;

namespace Compliance360.Models
{
  public class BaseClass
  {
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime DateModified { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsSaved { get; set; }

    public BaseClass()
    {
      DateCreated = DateTime.Now;
      DateUpdated = DateTime.Now;
      DateModified = DateTime.Now;
    }

  }
}
