using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Calibration
    {
        [AllureStep("Press the Calibrate button")]
        public Calibration PressCalibrateButton()
        {
            WaitUntil.ElementIsClickable(_btnCalibrate);
            btnCalibrate.Click();

            return this;
        }

        [AllureStep("Select binary from the list - {0}")]
        public Calibration SelectBinary(string binaryName)
        {
            WaitUntil.VisibilityOfAllElementsLocatedBy(_cbbxBinaries, 20);
            cbbxBinaries.Click();  
            cbbxBinaries.FindElement(By.Name(binaryName)).Click();
            return this;
        }


        [AllureStep("Select calibration for selected binary - {0}")]
        public Calibration SelectCalibration(string calibration)
        {
            WaitUntil.ElementIsVisible(_cbbxCalibrations);
            cbbxCalibrations.Click();
            cbbxCalibrations.FindElement(By.Name(calibration)).Click();
            return this;
        }

        [AllureStep("Press Confirm button for binary information")]
        public Calibration PressConfirmButtonForBinaryInfo()
        {
            WaitUntil.ElementIsVisible(_btnConfirmEcuInformation);
            btnConfirmEcuInformation.Click();
            return this;
        }

        [AllureStep("Select binary from the list - {0}")]
        public Calibration SelectBinaryOEM(string binaryName)
        {
            WaitUntil.ElementIsVisible(_lbEcus);
            lbEcus.FindElement(By.Name(binaryName)).Click();
            return this;
        }

        [AllureStep("Select calibration for selected binary - {0}")]
        public Calibration SelectCalibrationOEM(string calibration)
        {
            WaitUntil.ElementIsVisible(_lbCalibrations);
            lbCalibrations.FindElement(By.Name(calibration)).Click();
            return this;
        }

    }
}
