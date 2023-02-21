﻿namespace CSharpCore.Lessons.Classes.Partial
{
    public partial class User
    {
        public string FullName { get
            {
                return string.Join(Firstname, " ", Lastname);
            } 
        }

        public override string? ToString()
        {
            return $"UserId = {UserId}, Username = {Username}, Password = {Password}, Fullname = {FullName}";
        }
    }
}
