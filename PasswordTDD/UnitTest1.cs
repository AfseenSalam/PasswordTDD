using ConsoleApp1;


namespace PasswordTDD
{
    public class UnitTest1
    {
        public List<string> passwords = new List<string>()
        {
            "mod","pAsswOrd1","h4CkErShIt"};
        [Theory]
        [InlineData("pAsswOrd1", false)]//existing one
        [InlineData("mod", false)]//existing one
        [InlineData("PrInglE5", true)]//new password
        [InlineData("NOspAcE1", true)]//nospace
        [InlineData("HEllo World", false)]// space
        [InlineData("ValidPass1", true)] // Length is 10
        [InlineData("Short1", false)] // Length is 6
        [InlineData("VeryLongPassword123", false)]
        [InlineData("ValidPass1", true)]
        [InlineData("Pass6", false)] // Contains 6
        [InlineData("PassvAl6", false)]//no number and 
        [InlineData("A1", false)]//1 capital
        [InlineData("admin", true)] // Allowed
        [InlineData("2", true)] // Prime number
        [InlineData("5", true)]// Prime number
        [InlineData("61", false)]
        public void Validating(string pass,bool expect)
        {
            var result = Storage.AddPassword(pass, passwords);
            Assert.Equal(expect, result);
           
        }
       

    }
}