namespace CatWorx.BadgeMaker
{
  class Employee
  {
    private string FirstName;
    //By default, properties and methods defined in a class are given the protection level
    //of private, which means that they can only be accessed within the class itself
            //"public" or "private" are referred to as access modifiers
                //To distinguish between public and private variables, use PascalCase for 
                //public variables and camelCase for private variables.
    private string LastName;
    private int Id;
    private string PhotoUrl;
    public Employee(string firstName, string lastName, int id, string photoUrl) {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        PhotoUrl = photoUrl;
    }
    public string GetFullName() {
        return FirstName + " " + LastName;
    }
     public int GetId() {
        return Id;
    }
    public string GetPhotoUrl() {
        return PhotoUrl;
    }
  }
}