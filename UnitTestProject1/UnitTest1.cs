
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace UnitTest1
{
    [TestFixture]
    public class Class1
    {


        [Test]
        public void FacultyPublication()
        {
            string Url = "http://172.16.18.106/rmsstage";
            IWebDriver driver = new ChromeDriver();


            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            //driver.Url = "http://172.16.51.47/RMSPublish/Login.aspx";
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).SendKeys("fassv4");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_Button1")).Click();
            Task.Delay(2000);


            var option = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DropDownListPublicationEntry"));
            var selectElement = new SelectElement(option);
            //System.Threading.Thread.Sleep(2000);
            selectElement.SelectByText("Journal Article");
            //Console.Read();
            Task.Delay(2000).Wait();
            //Actions builder = new Actions(driver);
            //builder.SendKeys(Keys.Enter);
            // _ = driver.SwitchTo().Alert();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtboxTitleOfWrkItem")).SendKeys("Karnataka");
            Task.Delay(2000).Wait();

            var option2 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DropDownListMuCategory"));
            var selectoption = new SelectElement(option2);
            Task.Delay(4000).Wait();
            //System.Threading.Thread.Sleep(2000);
            selectoption.SelectByText("Book");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtboxTitleOfWrkItem")).SendKeys("Karnataka");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxAbstract")).SendKeys("One State Many Worlds");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxKeywords")).SendKeys("Places");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxDOINum")).SendKeys("171");
            Task.Delay(2000).Wait();

            var option3 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DropDownListhasProjectreference"));
            var select_option = new SelectElement(option3);
            //System.Threading.Thread.Sleep(2000);
            select_option.SelectByText("No");
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_EditUpdatePanel"));

            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_imageBkCbtn")).Click();
            //Task.Delay(2000).Wait();

            //driver.FindElement(By.XPath("//body//div[@id='commentpopup2']//tr//tr[2]//td[1]")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_BtnAddMU")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_EmployeeCodeBtn")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//body//div[@id='commentpopup']//tr//tr[2]//td[1]")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl03_EmployeeCodeBtn")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_affiliateSrch")).SendKeys("sreepathy");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_BtnEmployeeSearch")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//body//div[@id='commentpopup']//td//td[1]")).Click();
            Task.Delay(2000).Wait();

            var author = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_isCorrAuth"));
            var select_author = new SelectElement(author);
            //System.Threading.Thread.Sleep(2000);
            select_author.SelectByText("No");
            Task.Delay(2000).Wait();

            var author1 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_AuthorType"));
            var select_author1 = new SelectElement(author1);
            //System.Threading.Thread.Sleep(2000);
            select_author1.SelectByIndex(1);
            Task.Delay(2000).Wait();

            var author2 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl03_AuthorType"));
            var select_author2 = new SelectElement(author2);
            //System.Threading.Thread.Sleep(2000);
            select_author2.SelectByIndex(2);
            Task.Delay(2000).Wait();

            var author3 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl03_isCorrAuth"));
            var select_author3 = new SelectElement(author3);
            //System.Threading.Thread.Sleep(2000);
            select_author3.SelectByText("Yes");
            Task.Delay(2000).Wait();



            //driver.SwitchTo().Window();

            //driver.SwitchTo().Window(Ex);

            //driver.Navigate().Forward();

            //driver.Navigate().Refresh();
            //driver.SwitchTo().Frame(0);



            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_imageBkCbtn']")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//body//div[@id='commentpopup2']//tr//tr[2]//td[1]")).Click();
            Task.Delay(2000).Wait();

            //var element = driver.FindElement(By.Id("closeButton"));

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxVolume")).SendKeys("30");
            Task.Delay(2000).Wait();



            var month = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DropDownListMonthJA"));
            var select_month = new SelectElement(month);
            //System.Threading.Thread.Sleep(2000);
            select_month.SelectByText("July");
            Task.Delay(2000).Wait();




            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnSave")).Click();
            Task.Delay(4000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxWorkItemSearch")).SendKeys("Karnataka");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_ButtonSearchPub")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_GridViewSearch_ctl02_BtnEdit")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ctl00$ContentPlaceHolder1$CheckboxIndexAgency$0")).Click();
            //Task.Delay(2000).Wait();



            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_imageBkCbtn']")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//body//div[@id='commentpopup2']//tr//tr[2]//td[1]")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxPageFrom")).SendKeys("1");
            Task.Delay(2000).Wait();

            //driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_TextBoxPageTo']")).SendKeys("10");
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("FileUploadPdf")).SendKeys("C:\\Users\\SOIS\\Downloads\\ADC_code.pdf");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Buttonupload")).Click();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_BtnFeedback")).Click();
            Task.Delay(4000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_TextBoxPageTo']")).SendKeys("2");
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_CheckboxIndexAgency_1']")).Click();
            Task.Delay(2000).Wait();

            // driver.FindElement(By.Id("FileUploadPdf")).SendKeys("C:\\Users\\SOIS\\Downloads\\ADC_code.pdf");
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_BtnFeedback")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Buttonupload"));
            //Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnSave")).Click();
            //Task.Delay(4000).Wait();

            //driver.SwitchTo().Alert().Accept();
            //Task.Delay(6000).Wait();






            //var option2 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DropDownListMuCategory"));
            //var selectoption = new SelectElement(option2);
            //System.Threading.Thread.Sleep(2000);
            //selectoption.SelectByText("Book");
            //Task.Delay(2000).Wait();

            //var year = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DropDownListhasProjectreference"));
            //var select_year = new SelectElement(year);
            //System.Threading.Thread.Sleep(2000);
            //select_year.SelectBy("No");
            // Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxPubJournal")).SendKeys("12345");
            // Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxNameJournal")).SendKeys("Karnataka");
            // Task.Delay(2000).Wait();




            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnfedbackexit")).Click();
            Task.Delay(4000).Wait();

            driver.FindElement(By.Id("ctl00_Label3")).Click();
            Task.Delay(4000).Wait();                                                                  //Faculty Logout
            driver.Close();
        }

        //driver.FindElement(By.XPath("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_EmployeeCode")).SendKeys("543");
        //Task.Delay(2000).Wait();
        //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxNameJournal")).SendKeys("Dhruva");
        // Task.Delay(2000).Wait();
        /* driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_InstitutionName")).SendKeys("SOIS");
         Task.Delay(2000).Wait();
         driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_DepartmentName")).SendKeys("CDC");
         Task.Delay(2000).Wait();
         driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_MailId")).SendKeys("dhruva.sehwag@gmail.com");
         Task.Delay(2000).Wait();
         driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_NameInJournal")).SendKeys("KA");
         Task.Delay(2000).Wait();*\

         //IAlert simpleAlert = driver.SwitchTo().Alert();
         //String alertText = simpleAlert.Text;
         //Console.WriteLine("Entry can be done only for Published Articles......Do You Want To Continue? " + alertText);
         //simpleAlert.Accept();
         //
         //Task.Delay(2000);



         //driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_DropDownListPublicationEntry']")).Click();
         //[@id="ctl00_ContentPlaceHolder1_DropDownListPublicationEntry"]
         /*driver.FindElement(By.XPath("//a[contains(text(),'Search')]")).Click();
         Task.Delay(2000);
         driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_TextBox1']")).SendKeys("Information");
         driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_BtnSearch']")).Click();
         Task.Delay(2000);
         string expt = driver.FindElement(By.XPath("//span[@id='ctl00_ContentPlaceHolder1_GridView1_ctl02_EmailId']")).GetAttribute("innerHTML");
         Console.Write(expt);
         Assert.AreEqual("ravindra.prabhu@manipal.edu", expt);
         Task.Delay(2000);
         */


        // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        // IWebElement link_patent = driver.FindElement(By.LinkText("Search"));
        //Actions actions = new Actions(driver);
        //IAction mouseOverHome = actions.MoveToElement(link_patent).Build();
        //mouseOverHome.Perform();

        // WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        //IWebElement link_patent_entry = driver.FindElement(By.LinkText("Keyword Based"));
        //Actions action = new Actions(driver);
        //IAction mouseOverList = actions.MoveToElement(link_patent_entry).Click().Build();
        //mouseOverList.Perform();
        //Task.Delay(5000);
        //driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_TextBox1']")).SendKeys("Information");
        // Task.Delay(2000);
        //driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_BtnSearch']")).Click();
        //Task.Delay(5000);
        //string expt = driver.FindElement(By.XPath("//span[@id='ctl00_ContentPlaceHolder1_GridView1_ctl02_EmailId']")).GetAttribute("innerHTML");
        //Console.Write(expt);
        //Assert.AreEqual("brayal.dsouza@manipal.edu", expt);
        //driver.FindElement(By.XPath("//span[@id='ctl00_Label3']")).Click();

        //driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[3]/div[2]/nav[1]/ul[1]/li[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/a[1]")).Click();
        /*IWebElement drp = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DrpSelect"));
        SelectElement oSelect = new SelectElement(drp);
        oSelect.SelectByText("Nationality");
        Task.Delay(2000);
        IWebElement drpnat = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DrpNational"));
        SelectElement oSelectnat = new SelectElement(drpnat);
        oSelectnat.SelectByText("INDIA");
        Task.Delay(2000);
        driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_searchbtn")).Submit();*/
        [Test]
        public void LibrarianApproval()
        {
            string Url = "http://172.16.18.106/rmsstage";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);


            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).SendKeys("fassu3");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_Button1")).Click();
            Task.Delay(2000);


            //driver.FindElement(By.XPath("//td[@id='ctl00_menuBarn7']//table//tbody//tr//td//a[@class='ctl00_menuBar_1'][contains(text(),'Incentive Point')]")).Click();

            //var option5 = driver.FindElement(By.XPath("//td[@id='ctl00_menuBarn7']//table//tbody//tr//td//a[@class='ctl00_menuBar_1'][contains(text(),'Incentive Point')]"));
            //var selectentry = new SelectElement(option5);
            //System.Threading.Thread.Sleep(2000);
            //selectentry.SelectByText("Incentive Point Entry");
            //Task.Delay(2000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement link_patent = driver.FindElement(By.LinkText("Incentive Point"));
            Actions actions = new Actions(driver);
            IAction mouseOverHome = actions.MoveToElement(link_patent).Build();
            mouseOverHome.Perform();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement link_patent_entry = driver.FindElement(By.LinkText("Incentive Point Entry"));
            Actions action = new Actions(driver);
            IAction mouseOverList = actions.MoveToElement(link_patent_entry).Click().Build();
            mouseOverList.Perform();
            Task.Delay(5000);



            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_EntryTypesearch"));
            var option6 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_EntryTypesearch"));
            var selecttype = new SelectElement(option6);
            //System.Threading.Thread.Sleep(2000);
            selecttype.SelectByText("Journal Article");
            Task.Delay(2000);

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_PubIDSearch")).SendKeys("00000454");
            Task.Delay(2000);



            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_ButtonSearchPub")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_GridViewSearch_ctl02_BtnEdit")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_txtBasePoint")).SendKeys("5");
            //Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl03_txtBasePoint")).SendKeys("5");
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl03_txtBasePoint")).SendKeys("5");
            //Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_ButtonConfirm")).Click();
            //Task.Delay(2000).Wait();
            //driver.SwitchTo().Alert().Accept();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnApprove")).Click();
            Task.Delay(2000).Wait();



            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(8000).Wait();


            driver.FindElement(By.Id("ctl00_Label3")).Click();
            Task.Delay(4000).Wait();
            //librarian approval
            driver.Close();        
        
        }



        [Test]
        public void Approval()
        {
            string Url = "http://172.16.18.106/rmsstage";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);



            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).SendKeys("fassv2");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_Button1")).Click();
            Task.Delay(2000);

            var option7 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_EntryTypesearch"));
            var selectother = new SelectElement(option7);
            //System.Threading.Thread.Sleep(2000);
            selectother.SelectByText("Journal Article");
            Task.Delay(2000);

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_PubIDSearch")).SendKeys("00000454");
            Task.Delay(2000);



            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_ButtonSearchPub")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_GridViewSearch_ctl02_BtnEdit")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxEprintURL")).SendKeys("www.google.com");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtContent")).SendKeys("information");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnSendNotification")).Click();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();                                                              //send notification


            driver.FindElement(By.Id("ctl00_Label3")).Click();
            Task.Delay(4000).Wait();

            //driver.Close();



            //driver.FindElement(By.Id("ctl08_UserName")).SendKeys("chaitanya.cvs");
            //driver.FindElement(By.Id("ctl08_UserPass")).SendKeys("Chaitucvs_6");
            //driver.FindElement(By.Id("ctl08_cmdLogin")).Click();
            //Task.Delay(2000);
            //IWebElement drp = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DrpSelect"));
            //SelectElement oSelect = new SelectElement(drp);

            //oSelect.SelectByText("Nationality");
            //Task.Delay(2000);
            //IWebElement drpnat = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DrpNational"));
            //SelectElement oSelectnat = new SelectElement(drpnat);

            //oSelectnat.SelectByText("INDIA");
            //Task.Delay(2000);
            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_searchbtn")).Submit();

            driver.Close();
        }

        [Test]
        public void failtest()
        {
            string Url = "http://172.16.18.106/rmsstage";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);



            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).SendKeys("fassv2");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_Button1")).Click();
            Task.Delay(2000);

            var option7 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_EntryTypesearch"));
            var selectother = new SelectElement(option7);
            //System.Threading.Thread.Sleep(2000);
            selectother.SelectByText("Journal Article");
            Task.Delay(2000);

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_PubIDSearch")).SendKeys("00000453");
            Task.Delay(2000);



            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_ButtonSearchPub")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_GridViewSearch_ctl02_BtnEdit")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxEprintURL")).SendKeys("www.google.com");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtContent")).SendKeys("information");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnSendNotification")).Click();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();                                                              //send notification


            driver.FindElement(By.Id("ctl00_Label3")).Click();
            Task.Delay(4000).Wait();
        }
        }
    }