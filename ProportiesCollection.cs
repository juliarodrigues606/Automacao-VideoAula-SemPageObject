using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace VideoAula
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    class ProportiesCollection
    {

       public static IWebDriver driver { get; set; }

    }
}
