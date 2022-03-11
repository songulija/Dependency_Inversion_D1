namespace DemoLibrary
{
    /// <summary>
    /// Everything depends,tied basically on Person class. and its not good
    /// 
    /// </summary>
    public interface IPerson
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
    }
}