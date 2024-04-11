using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class Prueba4
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

            //ingresar contrasena 
            IWebElement cnt = driver.FindElement(By.Id("password"));
            cnt.SendKeys("Alexandro.19");

            //pulsar el btn inicio de seccion

            IWebElement btn = driver.FindElement(By.Id("btnLogin"));
            btn.Click();

            System.Threading.Thread.Sleep(2000);
        }
    }
}
