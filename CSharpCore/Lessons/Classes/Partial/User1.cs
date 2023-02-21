namespace CSharpCore.Lessons.Classes.Partial
{
    public partial class User
    {
        public int UserId { set; get; }
        public string Username { set; get; } = null!;
        public string Password { set; get; } = null!;
        public string Firstname { set; get; } = null!;
        public string Lastname { set; get; } = null!;
    }
}
