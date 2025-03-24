using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

[TestFixture]
public class Parcial2Test {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  
  [SetUp]
  public void SetUp() {
    driver = new FirefoxDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  
  [Test]
  public void parcial2() {
    for(int i = 0; i < 100; i++) {
      Console.WriteLine($"Ejecutando iteración #{i + 1}");
      
      try {
        driver.Navigate().GoToUrl("http://localhost/Login-Avanzado-Php-MySql-JS-CSS-HTML/");
        driver.Manage().Window.Size = new System.Drawing.Size(1721, 927);
        driver.FindElement(By.Name("nombre_completo")).Click();
        driver.FindElement(By.Name("nombre_completo")).SendKeys("javier cruz");
        driver.FindElement(By.CssSelector(".formulario__register > input:nth-child(3)")).Click();
        driver.FindElement(By.CssSelector(".formulario__register > input:nth-child(3)")).SendKeys("javi18cr1999@gmail.com");
        driver.FindElement(By.Name("usuario")).Click();
        driver.FindElement(By.Name("usuario")).SendKeys("javier");
        driver.FindElement(By.CssSelector("input:nth-child(5)")).Click();
        driver.FindElement(By.CssSelector("input:nth-child(5)")).SendKeys("12345678");
        driver.FindElement(By.CssSelector("button:nth-child(6)")).Click();
        
        Console.WriteLine($"Iteración #{i + 1} completada con éxito");
      }
      catch(Exception ex) {
        Console.WriteLine($"Error en iteración #{i + 1}: {ex.Message}");
        // Puedes decidir si quieres continuar con las siguientes iteraciones
        // o romper el bucle con un 'break;' si prefieres detenerte ante errores
      }
      
      // Pequeña pausa entre iteraciones para evitar sobrecarga
      Thread.Sleep(500);
    }
  }
}