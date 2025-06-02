using System;
using System.Collections.Generic;

namespace DbFirst;

public partial class BlogComment
{
    public long CommentId { get; set; }

    public long PostId { get; set; }

    public string Title { get; set; } = null!;

    public string CommentText { get; set; } = null!;

    public string CommentBy { get; set; } = null!;

    public virtual BlogPost Post { get; set; } = null!;
}
