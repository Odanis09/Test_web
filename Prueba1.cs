﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;



namespace testselenium
{
    internal class Prueba1
    {
        static void Main(string[] args)
        {
            

     
            IWebDriver driver = new FirefoxDriver ();
            driver.Navigate().GoToUrl("https://sigeiacademico.itla.edu.do/account/login");
            driver.Manage().Window.Maximize (); //



            //1er caso
            //ingresar email
            IWebElement input = driver.FindElement(By.Id("email"));
            input.SendKeys("odanisoto.19@gmail.com");

            //ingresar contrasena
            IWebElement cnt = driver.FindElement(By.Id ("password"));
            cnt.SendKeys("Alexandro.19");

            //pulsar el btn inicio de seccion

            IWebElement btn = driver.FindElement(By.Id("btnLogin"));
            btn.Click();

            System.Threading.Thread.Sleep(2000);


            
            

           







        }
    }
}
