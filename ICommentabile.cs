using sccms.Models;

namespace sccms;

public interface ICommentabile
{
    public List<Comment> Comments { get; set; }
}