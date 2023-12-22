namespace SiPetani.Models
{
	public class CredentialModel
	{
        public int Credential_Id { get; set; }
		public int User_Id { get; set; }
		public int Role_Id { get; set; }
		public string Username { get; set;}
		public string Password { get; set;}
    }
}
