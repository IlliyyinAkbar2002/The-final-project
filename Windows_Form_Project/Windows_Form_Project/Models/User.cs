namespace Windows_Form_Project.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string Nama { get; set; }
        public string NIK { get; set; }
        public string RT { get; set; }
        public string RW { get; set; }

        public User(string username, string password, Role role, string nama, string nik, string rt, string rw)
        {
            Username = username;
            Password = password;
            Role = role;
            Nama = nama;
            NIK = nik;
            RT = rt;
            RW = rw;
        }
    }
}
