using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID101.SRP
{
    public class UserCreator
    {
        private readonly UserValidator _validator;
        private readonly UserRepository _repository;

        public UserCreator(UserValidator validator, UserRepository repository)
        {
            _validator = validator;
            _repository = repository;
        }

        public void CreateUser(string username, string email, string password)
        {
            if (!_validator.ValidateEmail(email))
            {
                throw new ArgumentException("Invalid email format.");
            }

            // Business rules

            _repository.SaveUser(username, email, password);
        }
    }
}
