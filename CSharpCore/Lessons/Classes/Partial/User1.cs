namespace CSharpCore.Lessons.Classes.Partial
{
    public partial class User
    {
        public int UserId { init; get; }
        public string Username { init; get; } = null!;
        public string Password { init; get; } = null!;
        public string Firstname { init; get; } = null!;
        public string Lastname { init; get; } = null!;
    }
}
