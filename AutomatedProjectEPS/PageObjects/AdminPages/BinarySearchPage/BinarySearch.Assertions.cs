using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class BinarySearch
    {
        [AllureStep("Make Sure that created binary found")]
        public BinarySearch MakeSureBinaryFound(string binaryLabel)
        {
            WaitUntil.VisibilityOfAllElementsLocatedBy(By.Name(binaryLabel));
            Assert.AreEqual(binaryLabel, elemFromList.Text);
            return this;
        }
    }
}
