using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace VideoAula
{
    class SeleniumSetMethods
    {

        public static void EnterText(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                ProportiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == PropertyType.Name)
                ProportiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == PropertyType.ClassName)
                ProportiesCollection.driver.FindElement(By.ClassName(element)).SendKeys(value);
            if (elementType == PropertyType.LinkText)
                ProportiesCollection.driver.FindElement(By.LinkText(element)).SendKeys(value);
        }

        public static void Click(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                ProportiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementType == PropertyType.Name)
                ProportiesCollection.driver.FindElement(By.Name(element)).Click();
            if (elementType == PropertyType.ClassName)
                ProportiesCollection.driver.FindElement(By.ClassName(element)).Click();
            if (elementType == PropertyType.LinkText)
                ProportiesCollection.driver.FindElement(By.LinkText(element)).Click();
        }

        public static void SelectDropDown(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                new SelectElement(ProportiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == PropertyType.Name)
                new SelectElement(ProportiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementType == PropertyType.ClassName)
                new SelectElement(ProportiesCollection.driver.FindElement(By.ClassName(element))).SelectByText(value);
        }
    }
}
