namespace DapperWithMinimalAPI.Models
{
    public  class Account
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public int? EmailVerified { get; set; }

        public string CellPhone { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string StateCode { get; set; }

        public string VerificationCode { get; set; }
    }

}
