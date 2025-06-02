using System;
using System.Collections.Generic;

namespace DbFirst;

public partial class BlogPost
{
    public long PostId { get; set; }

    public string Title { get; set; } = null!;

    public string PostText { get; set; } = null!;

    public string PostedBy { get; set; } = null!;

    public virtual ICollection<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
}
