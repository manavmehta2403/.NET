using Learning_Task;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Learning_Task_Test
{
  [TestClass]
  public class MainWindowTest
  {
    [TestMethod]
    public void Save_Btn_Test()
    {
      MainWindow mw = new MainWindow();

      string result = mw.Write("Test Done");

      Assert.AreEqual("Test Done", result);
    }
  }
}
