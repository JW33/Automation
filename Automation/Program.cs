using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hour (include 0):");
            var hour = Console.ReadLine();
            Console.WriteLine("Minute (include 0 if needed):");
            var minute = Console.ReadLine();
            Console.WriteLine("Meridian:");
            var meridian = Console.ReadLine().ToUpper();

            Console.WriteLine("EntryId:");
            var entryId = Console.ReadLine();
            var box1 = entryId.Substring(0, 3);
            var box2 = entryId.Substring(3, 3);
            var box3 = entryId.Substring(6, 3);
            var box4 = entryId.Substring(9, 3);
            var box5 = entryId.Substring(12, 3);
            var box6 = entryId.Substring(15, 3);
            // 034 344 105 748 500 605


            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.krogerexperience.com/");

            // Not working yet...
            //var date_field = driver.FindElementById("Index_VisitDateDatePicker");
            //date_field.SendKeys(date);
            //var date_field = driver.FindElement(By.XPath("//*[@id=\"Index_VisitDateDatePicker\"]"));
            //date_field.SendKeys("03/08/2020");
            //date_field.SendKeys(date);

            var hour_field = driver.FindElementById("InputHour");
            SelectElement select1 = new SelectElement(hour_field);
            select1.SelectByText(hour);

            var minute_field = driver.FindElementById("InputMinute");
            SelectElement select2 = new SelectElement(minute_field);
            select2.SelectByText(minute);

            var meridian_field = driver.FindElementById("InputMeridian");
            SelectElement select3 = new SelectElement(meridian_field);
            select3.SelectByText(meridian);

            var CN1 = driver.FindElementById("CN1");
            CN1.SendKeys(box1);

            var CN2 = driver.FindElementById("CN2");
            CN2.SendKeys(box2);

            var CN3 = driver.FindElementById("CN3");
            CN3.SendKeys(box3);

            var CN4 = driver.FindElementById("CN4");
            CN4.SendKeys(box4);

            var CN5 = driver.FindElementById("CN5");
            CN5.SendKeys(box5);

            var CN6 = driver.FindElementById("CN6");
            CN6.SendKeys(box6);

            var next = driver.FindElementById("NextButton");
            next.Click();

            var overallSatisfaction = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[2]/td[2]/span"));
            overallSatisfaction.Click();
            next.Click();

            //Skip additional feedback
            next.Click();

            var one = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[2]/td[2]/span"));
            one.Click();
            var two = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[3]/td[2]/span"));
            two.Click();
            var three = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[4]/td[2]/span"));
            three.Click();
            var four = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[5]/td[2]/span"));
            four.Click();
            var five = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[6]/td[2]/span"));
            five.Click();
            var six = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[7]/td[2]/span"));
            six.Click();
            var seven = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[8]/td[2]/span"));
            seven.Click();
            var eight = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[9]/td[2]/span"));
            eight.Click();
            var nine = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[10]/td[2]/span"));
            nine.Click();
            var ten = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[11]/td[2]/span"));
            ten.Click();
            next.Click();


            var department = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/div[1]/div[2]/div/div[7]/span/span"));
            department.Click();
            next.Click();


            var meatOne = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[2]/td[2]/span"));
            meatOne.Click();
            var meatTwo = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[3]/td[2]/span"));
            meatTwo.Click();
            var meatThree = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[4]/td[2]/span"));
            meatThree.Click();
            var meatFour = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[5]/td[2]/span"));
            meatFour.Click();
            var meatFive = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[6]/td[2]/span"));
            meatFive.Click();
            var meatSix = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[7]/td[2]/span"));
            meatSix.Click();
            next.Click();


            var employee = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[2]/td[4]/span"));
            employee.Click();
            next.Click();


            var problem = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[2]/td[3]/span"));
            problem.Click();
            next.Click();


            var recognize = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[2]/td[3]/span"));
            recognize.Click();
            next.Click();


            //Skip additional feedback
            next.Click();

            var comeBack = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[2]/td[2]/span"));
            comeBack.Click();
            next.Click();


            var age = driver.FindElementById("R002004");
            SelectElement selectAge = new SelectElement(age);
            selectAge.SelectByText("45");
            next.Click();


            var gender = driver.FindElementById("R002004");
            SelectElement selectGender = new SelectElement(gender);
            selectGender.SelectByText("Prefer not to answer");
            next.Click();


            var adults = driver.FindElementById("R002017");
            SelectElement selectAdults = new SelectElement(adults);
            selectAdults.SelectByText("Prefer not to answer");
            var children = driver.FindElementById("R002018");
            SelectElement selectChildren = new SelectElement(children);
            selectChildren.SelectByText("Prefer not to answer");
            next.Click();

            var education = driver.FindElementById("R002005");
            SelectElement selectEducation = new SelectElement(education);
            selectEducation.SelectByText("Prefer not to answer");
            var income = driver.FindElementById("R002006");
            SelectElement selectIncome = new SelectElement(income);
            selectIncome.SelectByText("Prefer not to answer");
            next.Click();

            var background = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/div[1]/div[2]/div/div[8]/span/span"));
            background.Click();
            next.Click();

            var familyEmployed = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[2]/td[3]/span"));
            familyEmployed.Click();
            next.Click();

            var sweepstakes = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/table/tbody/tr[2]/td[3]/span"));
            sweepstakes.Click();
            next.Click();

            var loyalty = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/div/div[1]/div[2]/div/div[1]/span/span"));
            loyalty.Click();
            next.Click();

            var cardNum = driver.FindElementById("R003006");
            cardNum.SendKeys("435698229646");
            next.Click();
        }
    }
}
