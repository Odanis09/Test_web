using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace test22
{
    internal class pruebados
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://sigeiacademico.itla.edu.do/account/login");
            driver.Manage().Window.Maximize(); //



            //2do caso
            //ingresar email incorrecto
            IWebElement input = driver.FindElement(By.Id("email"));
            input.SendKeys("choncho@gmail.com");

            //ingresar contrasena incorrecta
            IWebElement cnt = driver.FindElement(By.Id("password"));
            cnt.SendKeys("123.19");

            //pulsar el btn inicio de seccion

            IWebElement btn = driver.FindElement(By.Id("btnLogin"));
            btn.Click();

            System.Threading.Thread.Sleep(2000);
        }
    }
}
