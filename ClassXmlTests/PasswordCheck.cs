using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryPassword;

namespace ClassXmlTests
{
    [TestClass]
    public class PasswordCheck
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",@"testData.xml","Password",DataAccessMethod.Sequential)]

        
        [TestMethod]
        public void ClassLibraryPassword_Data()
        {
            //arrange
            string password = Convert.ToString(TestContext.DataRow["password"]);
            //act
            bool result = PasswordChecker.ValidatePassword(password);
            //assert
            Assert.IsTrue(result,"Пароль не соблюдает всех норм");
        }
    }
}
