﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class FormObject :PageObject
    {
        public FormObject(RemoteWebDriver driver) : base(driver)
        {
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }
    }
}
