namespace IT_Q2_32E2_Antonio_MarcKevin.DTO.User
{
    public class GetUsersResponse
    {
        public List<GetUsersDTO> Users{ get; set; }
        public int totalcount => Users?.Count ?? 0;
    }
    public class GetUsersDTO
    {
        public int id { get; set;}
        public string name { get; set;}
        public string email { get; set;}
    }

}
