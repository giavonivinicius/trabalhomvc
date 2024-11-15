using System;

namespace PimUrbanGreen.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}
