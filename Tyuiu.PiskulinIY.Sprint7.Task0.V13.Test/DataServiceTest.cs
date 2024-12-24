using System.IO;
using System.Diagnostics;
using Tyuiu.PiskulinIY.Sprint7.Task0.V13.Lib;

namespace Tyuiu.PiskulinIY.Sprint7.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint7\Tyuiu.PiskulinIY.Sprint7.Task0.V13\bin\Debug\net8.0-windows\Ru.txt";
            
            FileInfo fileInfo = new FileInfo(path);
            
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            
            Assert.AreEqual(wait, fileExists);

            //проверка на наличие файла


        }
    }
}