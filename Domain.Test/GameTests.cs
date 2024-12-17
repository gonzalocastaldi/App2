using App2;

namespace Domain.Test;

[TestClass]
public class GameTests
{
    [TestMethod]
    public void  CreateUser_validParameters_createsUser()
    {
        User user = new User();
        user.UserName = "test";
        user.Password = "test";
        Assert.AreEqual("test", user.UserName);
    }
}