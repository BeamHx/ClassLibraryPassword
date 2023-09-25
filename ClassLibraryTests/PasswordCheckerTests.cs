using ClassLibraryPassword;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryPassword;

namespace ClassLibraryTests
{
    [TestClass]
    public class PasswordCheckerTests
    {
        
        /// <summary>
        /// // Пустая строка
        /// </summary>
        [TestMethod]
        public void Check_EmptyString_ReutrnsFalse() 
        {
            //Arrange
            string password = "";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///   Корректный пароль
        /// </summary>
        [TestMethod]
        public void Check_Symbols_ReutrnsTrue() 
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Количество символов меньше 8, FALSE
        /// </summary>

        [TestMethod]
        public void Check_4Symbols_ReutrnsFalse() 
        {
            //Arrange
            string password = "Aq1$";
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка пограничного значения TRUE(8 символов)
        /// </summary>

        [TestMethod]
        public void Check_8Sybmbols_ReutrnsTrue() 
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected,actual);
        }
        /// <summary>
        /// Проверка пограничного значения (20) , TRUE
        /// </summary>

        [TestMethod]
        public void Check_20Sybmbols_ReutrnsFalse()
        {
            //Arrange
            string password = "sdfdsfsdf!dlsd!Sf!1!";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Количество символов больше 20, FALSE
        /// </summary>

        [TestMethod]
        public void Check_20PlusSybmbols_ReutrnsFalse() 
        {
            //Arrange
            string password = "ASDqwe123$ASDqwe123$ASDqwe123$";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
       
       
        /// <summary>
        /// Цифрор нет, FALSE
        /// </summary>

        [TestMethod]
        public void Check_DigitsExist2_ReutrnsFalse() 
        {
            //Arrange
            string password = "ASDqweASD$";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        /// <summary>
        /// Спецсимволов не встречаются, FALSE
        /// </summary>

        [TestMethod]
        public void Check_NotExistSpecSymbols_ReutrnsFalse() 
        {
            //Arrange
            string password = "ASDqwe123";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        

        /// <summary>
        /// Прописные не встречаются, FALSE
        /// </summary>

        [TestMethod]
        public void Check_NotExistUpperLetters_ReutrnsFalse()
        {
            //Arrange
            string password = "aqwer123$";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        /// <summary>
        /// Строчные не встречаются, FALSE
        /// </summary>

        [TestMethod]
        public void Check_NotExistLowerLetters2_ReutrnsFalse() 
        {
            //Arrange
            string password = "ASDQWE123$";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
