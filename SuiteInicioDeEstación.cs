using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestProject.Base;
using saucedemo.WebPage;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using static NetCoreConsoleSettings.ConfigHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ElevateCajaDav.WebPages;

namespace saucedemo.WebPages
{
    [TestClass]
      public class Suitesaucedemo : BaseSelenium
      {

          private TestContext testContextInstance;
        private object processLogin;

        public TestContext TestContext
          {
              get
              {
                  return testContextInstance;
              }
              set
              {
                testContextInstance = value;
              }
          }
             public object TittlePag { get; private set; }
        public bool Active { get; private set; }

        //public class Usuarios

        //  {
        //      public string Usuario { get; set; }
        //      public string Password { get; set; }
        //      public int ValidUser { get; set; }
        //   }

        public class URL

        {
            public string Url { get; set; }
            public string Protocolo { get; set; }


        }

        public class Roles
        {
            public string Value { get; set; }
            public Boolean Active { get; set; }

            public string jornada { get; set; }

            public string Usuario { get; set; }
            public string Password { get; set; }
            public int ValidUser { get; set; }
            public string Carrito { get; set; }

        }
////////////////////////////////////////////////////////////
///



/// <summary>
/// ///////////////////////////////////////////////////////
/// </summary>
        [TestMethod]
        [Description("Ingresar al módulo de cajas")]
        [TestCategory("SuiteLoginn")]
        public void Login()
        {
            try
            {
                //string activeRol = "";
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\WebData\\roles.json");
                using StreamReader jsonStream = File.OpenText(path);
                var json = jsonStream.ReadToEnd();
                List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(json);

                foreach (var Roles in roles)
                {
                    string Value = Roles.Value;
                    string Usuario = Roles.Usuario;
                    string Password = Roles.Password;

                    if (Value == "1")
                    {

                        GetDriver().Manage().Window.Maximize();
                        
                        ProcessLogin processLogin = new ProcessLogin();
                        String URL = processLogin.configLogin();

                        GetDriver().Navigate().GoToUrl(URL);

                       // CriterioPropio CriterioPropio = new CriterioPropio(GetDriver());
                        InicioDeEstación loginPage = new InicioDeEstación(GetDriver());
                       // CleanTestFolder();
                     

                        

                        loginPage.ClickUsername(Roles.Usuario);
                        SeleniumEvidence("InicioDeEstación");


                        loginPage.ClickPassword(Roles.Password);
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClickLogin();
                        SeleniumEvidence("InicioDeEstación");


                        string TittlePag = GetDriver().Title;

                        try
                        {
                            Assert.AreEqual(DomainData["Index"], TittlePag, "No Se ingresó correctamente");
                            // homepage.ClickLogOutBtn();
                        }
                        catch (Exception ex)
                        {
                            SeleniumEvidence("EvidenciaError");
                            Assert.Fail(ex.Message);
                        }
                        // CreateEvidenceDoc(TestContext.TestName);
                    }

                }
            }


            catch (Exception ex)
            {
                CreateEvidenceDoc(TestContext.TestName);
                Assert.Fail(ex.Message);
            }
                    CreateEvidenceDoc(TestContext.TestName);
        }

        [TestMethod]
        [Description("Ingresar al módulo de cajas")]
        [TestCategory("SuiteLoginn")]
        public void LoginInvali()
        {
            try
            {
                //string activeRol = "";
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\WebData\\roles.json");
                using StreamReader jsonStream = File.OpenText(path);
                var json = jsonStream.ReadToEnd();
                List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(json);

                foreach (var Roles in roles)
                {
                    string Value = Roles.Value;
                    string Usuario = Roles.Usuario;
                    string Password = Roles.Password;

                    if (Value == "0")
                    {

                        GetDriver().Manage().Window.Maximize();

                        ProcessLogin processLogin = new ProcessLogin();
                        String URL = processLogin.configLogin();

                        GetDriver().Navigate().GoToUrl(URL);

                        // CriterioPropio CriterioPropio = new CriterioPropio(GetDriver());
                        InicioDeEstación loginPage = new InicioDeEstación(GetDriver());
                        // CleanTestFolder();




                        loginPage.ClickUsername(Roles.Usuario);
                        SeleniumEvidence("InicioDeEstación");


                        loginPage.ClickPassword(Roles.Password);
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClickLogin();
                        SeleniumEvidence("InicioDeEstación");


                        string TittlePag = GetDriver().Title;


                        try
                        {
                            Assert.AreEqual(DomainData["Index"], TittlePag, "No Se ingresó correctamente");
                        }
                        catch (Exception ex)
                        {
                            SeleniumEvidence("EvidenciaError");
                            Assert.Fail(ex.Message);
                        }
                        // CreateEvidenceDoc(TestContext.TestName);
                    }

                }
            }


            catch (Exception ex)
            {
                CreateEvidenceDoc(TestContext.TestName);
                Assert.Fail(ex.Message);
            }
            CreateEvidenceDoc(TestContext.TestName);
        }
        [TestMethod]
        [Description("Ingresar al módulo de cajas")]
        [TestCategory("SuiteLoginn")]
        public void Logout()
        {
            try
            {
                //string activeRol = "";
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\WebData\\roles.json");
                using StreamReader jsonStream = File.OpenText(path);
                var json = jsonStream.ReadToEnd();
                List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(json);

                foreach (var Roles in roles)
                {
                    string Value = Roles.Value;
                    string Usuario = Roles.Usuario;
                    string Password = Roles.Password;

                    if (Value == "1")
                    {

                        GetDriver().Manage().Window.Maximize();

                        ProcessLogin processLogin = new ProcessLogin();
                        String URL = processLogin.configLogin();

                        GetDriver().Navigate().GoToUrl(URL);

                        // CriterioPropio CriterioPropio = new CriterioPropio(GetDriver());
                        InicioDeEstación loginPage = new InicioDeEstación(GetDriver());
                        // CleanTestFolder();




                        loginPage.ClickUsername(Roles.Usuario);
                        SeleniumEvidence("InicioDeEstación");


                        loginPage.ClickPassword(Roles.Password);
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClickLogin();
                        SeleniumEvidence("InicioDeEstación");


                        loginPage.MenuLogout();
                        SeleniumEvidence("InicioDeEstación");


                        loginPage.ClicSubMenuLogout();
                        SeleniumEvidence("InicioDeEstación");



                        string TittlePag = GetDriver().Title;

                        try
                        {
                            Assert.AreEqual(DomainData["Index"], TittlePag, "No Se ingresó correctamente");
                            // homepage.ClickLogOutBtn();
                        }
                        catch (Exception ex)
                        {
                            SeleniumEvidence("EvidenciaError");
                            Assert.Fail(ex.Message);
                        }
                        // CreateEvidenceDoc(TestContext.TestName);
                    }

                }
            }


            catch (Exception ex)
            {
                CreateEvidenceDoc(TestContext.TestName);
                Assert.Fail(ex.Message);
            }
            CreateEvidenceDoc(TestContext.TestName);
        }

        [TestMethod]
        [Description("Ingresar al módulo de cajas")]
        [TestCategory("SuiteLoginn")]
        public void Addproductstothecart()
        {
            try
            {
                //string activeRol = "";
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\WebData\\roles.json");
                using StreamReader jsonStream = File.OpenText(path);
                var json = jsonStream.ReadToEnd();
                List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(json);

                foreach (var Roles in roles)
                {
                    string Value = Roles.Value;
                    string Usuario = Roles.Usuario;
                    string Password = Roles.Password;
                    string Carrito = Roles.Carrito;
                    if (Carrito == "1")
                    {

                        GetDriver().Manage().Window.Maximize();

                        ProcessLogin processLogin = new ProcessLogin();
                        String URL = processLogin.configLogin();

                        GetDriver().Navigate().GoToUrl(URL);

                        // CriterioPropio CriterioPropio = new CriterioPropio(GetDriver());
                        InicioDeEstación loginPage = new InicioDeEstación(GetDriver());
                        // CleanTestFolder();




                        loginPage.ClickUsername(Roles.Usuario);
                        SeleniumEvidence("InicioDeEstación");


                        loginPage.ClickPassword(Roles.Password);
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClickLogin();
                        SeleniumEvidence("InicioDeEstación");


                        

                        loginPage.ClicAndToCartt();
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClicCar();
                        SeleniumEvidence("InicioDeEstación");
                        

                        string TittlePag = GetDriver().Title;

                        try
                        {
                            Assert.AreEqual(DomainData["Index"], TittlePag, "No Se ingresó correctamente");
                            // homepage.ClickLogOutBtn();
                        }
                        catch (Exception ex)
                        {
                            SeleniumEvidence("EvidenciaError");
                            Assert.Fail(ex.Message);
                        }
                        // CreateEvidenceDoc(TestContext.TestName);
                    }

                }
            }


            catch (Exception ex)
            {
                CreateEvidenceDoc(TestContext.TestName);
                Assert.Fail(ex.Message);
            }
            CreateEvidenceDoc(TestContext.TestName);
        }

        [TestMethod]
        [Description("Ingresar al módulo de cajas")]
        [TestCategory("SuiteLoginn")]
        public void Removeproductsfromthecart()
        {
            try
            {
                //string activeRol = "";
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\WebData\\roles.json");
                using StreamReader jsonStream = File.OpenText(path);
                var json = jsonStream.ReadToEnd();
                List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(json);

                foreach (var Roles in roles)
                {
                    string Value = Roles.Value;
                    string Usuario = Roles.Usuario;
                    string Password = Roles.Password;
                    string Carrito = Roles.Carrito;
                    if (Carrito == "1")
                    {

                        GetDriver().Manage().Window.Maximize();

                        ProcessLogin processLogin = new ProcessLogin();
                        String URL = processLogin.configLogin();

                        GetDriver().Navigate().GoToUrl(URL);

                        // CriterioPropio CriterioPropio = new CriterioPropio(GetDriver());
                        InicioDeEstación loginPage = new InicioDeEstación(GetDriver());
                        // CleanTestFolder();




                        loginPage.ClickUsername(Roles.Usuario);
                        SeleniumEvidence("InicioDeEstación");


                        loginPage.ClickPassword(Roles.Password);
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClickLogin();
                        SeleniumEvidence("InicioDeEstación");




                        loginPage.ClicAndToCartt();
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClicCar();
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClicRemove();
                        SeleniumEvidence("InicioDeEstación");


                        string TittlePag = GetDriver().Title;

                        try
                        {
                            Assert.AreEqual(DomainData["Index"], TittlePag, "No Se ingresó correctamente");
                            // homepage.ClickLogOutBtn();
                        }
                        catch (Exception ex)
                        {
                            SeleniumEvidence("EvidenciaError");
                            Assert.Fail(ex.Message);
                        }
                        // CreateEvidenceDoc(TestContext.TestName);
                    }

                }
            }


            catch (Exception ex)
            {
                CreateEvidenceDoc(TestContext.TestName);
                Assert.Fail(ex.Message);
            }
            CreateEvidenceDoc(TestContext.TestName);
        }

        [TestMethod]
        [Description("Ingresar al módulo de cajas")]
        [TestCategory("SuiteLoginn")]
        public void Completecheckout()
        {
            try
            {
                //string activeRol = "";
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\WebData\\roles.json");
                using StreamReader jsonStream = File.OpenText(path);
                var json = jsonStream.ReadToEnd();
                List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(json);

                foreach (var Roles in roles)
                {
                    string Value = Roles.Value;
                    string Usuario = Roles.Usuario;
                    string Password = Roles.Password;
                    string Carrito = Roles.Carrito;
                    if (Carrito == "1")
                    {

                        GetDriver().Manage().Window.Maximize();

                        ProcessLogin processLogin = new ProcessLogin();
                        String URL = processLogin.configLogin();

                        GetDriver().Navigate().GoToUrl(URL);

                        // CriterioPropio CriterioPropio = new CriterioPropio(GetDriver());
                        InicioDeEstación loginPage = new InicioDeEstación(GetDriver());
                        // CleanTestFolder();




                        loginPage.ClickUsername(Roles.Usuario);
                        SeleniumEvidence("InicioDeEstación");


                        loginPage.ClickPassword(Roles.Password);
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClickLogin();
                        SeleniumEvidence("InicioDeEstación");




                        loginPage.ClicAndToCartt();
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClicCar();
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClicCheckout();
                        SeleniumEvidence("InicioDeEstación");


                        loginPage.ClicfirstName();
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.CliclastName();
                        SeleniumEvidence("InicioDeEstación");
                        
                        loginPage.ClicpostalCode();
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClicContinue();
                        SeleniumEvidence("InicioDeEstación");

                        loginPage.ClicFinish();
                        SeleniumEvidence("InicioDeEstación");
                        Thread.Sleep(2000);
                        SeleniumEvidence("InicioDeEstación");

                        string TittlePag = GetDriver().Title;

                        try
                        {
                            Assert.AreEqual(DomainData["Index"], TittlePag, "No Se ingresó correctamente");
                            // homepage.ClickLogOutBtn();
                        }
                        catch (Exception ex)
                        {
                            SeleniumEvidence("EvidenciaError");
                            Assert.Fail(ex.Message);
                        }
                        // CreateEvidenceDoc(TestContext.TestName);
                    }

                }
            }


            catch (Exception ex)
            {
                CreateEvidenceDoc(TestContext.TestName);
                Assert.Fail(ex.Message);
            }
            CreateEvidenceDoc(TestContext.TestName);
        }

    }
}
