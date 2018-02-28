using System;

namespace StoreOFBuild.Domain
{
    public class Category
    {
        public int Id {get; private set;}

        public string Name {get ; private set;}

        public Category(string name)
        {
            ValidateNameAndSetName(name);
        }

        private void ValidateNameAndSetName(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "O nome é necessário");

            Name = name;
        }

        public void Update(string name)
        {
            
        }
    }
}
