using System;
using Academy.Models.Abstractions;

namespace Academy.Test
{
    public class UserMock : User
    {
        public UserMock(string username) : base(username)
        {
        }
    }
}