using BigBangAssesment.Models.DTO;

namespace BigBangAssesment.Interfaces
{
    public interface ITokenGenerate
    {
        public string GenerateToken(UserDTO user);
    }
}
