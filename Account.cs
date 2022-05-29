
namespace EmpManagement
{
    class Account
    {
        private string username;
        private string password;

        public Account()
        {

        }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get; set; }

        public string Password { get; set; }

    }
}
