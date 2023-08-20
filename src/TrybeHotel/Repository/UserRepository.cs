using TrybeHotel.Models;
using TrybeHotel.Dto;

namespace TrybeHotel.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly ITrybeHotelContext _context;
        public UserRepository(ITrybeHotelContext context)
        {
            _context = context;
        }
        public UserDto GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDto Login(LoginDto login)
        {
            throw new NotImplementedException();
        }
        public UserDto Add(UserDtoInsert user)
        {
            if (_context.Users.Any(u => u.Email == user.Email))
            {
                throw new Exception("User email already exists");
            }

            var newUser = new User
            {
                Email = user.Email,
                Password = user.Password,
                Name = user.Name,
                UserType = "client"
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return new UserDto
            {
                Email = newUser.Email,
                Name = newUser.Name,
                UserId = newUser.UserId,
                UserType = newUser.UserType
            };
        }

        public UserDto GetUserByEmail(string userEmail)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetUsers()
        {
            throw new NotImplementedException();
        }

    }
}