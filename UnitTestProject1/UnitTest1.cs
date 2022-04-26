using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using calculator;

namespace ce103_hw6_calc_app_cs_test
{
    [TestClass]
    public class CalcAccountTests
    {
        public bool Update { get; private set; }
        public object FontFamily { get; private set; }

        [TestMethod]
        public void RenderAll_Update()
        {
            // Arrange
            var account = new CalcAccountTests();
            // Act
            account.RenderAll();
            // Assert
            Assert.AreEqual(true, account.Update);



        }
        [TestMethod]
        private void RenderAll()
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void RenderSeries_Uptade()
        {
            var account = new CalcAccountTests();
            account.RenderSeries();
            Assert.AreEqual(FontFamily, 10);


        }
        [TestMethod]
        private void RenderSeries()
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void RenderXFunc_Update()
        {
            var account = new CalcAccountTests();
            account.RenderXFunc_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void DrawLinesSafe_Update()
        {
            var account = new CalcAccountTests();
            account.DrawLinesSafe_Update();
            Assert.AreEqual();

        }
        [TestMethod]
        public void DrawLinesWorkaround_Update()
        {
            var account = new CalcAccountTests();
            account.DrawLinesWorkaround_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void RenderXYFunc_Update()
        {
            var account = new CalcAccountTests();
            account.RenderXFunc_Update();
            Assert.AreEqual();

        }
        [TestMethod]
        public void RenderContourLines_Update()
        {
            var account = new CalcAccountTests();
            account.RenderContourLines_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void Min_Update()
        {
            var account = new CalcAccountTests();
            account.Min_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void Max_Update()
        {
            var account = new CalcAccountTests();
            account.Max_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void FindMinMax_Update()
        {
            var account = new CalcAccountTests();
            account.FindMinMax_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void GetMouseOverText_Update()
        {
            var account = new CalcAccountTests();
            account.GetMouseOverText_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void GraphRang_Update()
        {
            var account = new CalcAccountTests();
            account.GraphRang_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void Calculate_Update()
        {
            var account = new CalcAccountTests();
            account.Calculate_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void GetExpression_Update()
        {
            var account = new CalcAccountTests();
            account.GetExpression_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void Counting_Update()
        {
            var account = new CalcAccountTests();
            account.Counting_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void IsDelimeter_Update()
        {
            var account = new CalcAccountTests();
            account.IsDelimeter_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void GetPriority_Update()
        {
            var account = new CalcAccountTests();
            account.GetPriority_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void factorial_Update()
        {
            var account = new CalcAccountTests();
            account.factorial_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void NegativeFactorialExceptio_Update()
        {
            var account = new CalcAccountTests();
            account.NegativeFactorialExceptio_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void TgException_Update()
        {
            var account = new CalcAccountTests();
            account.TgException_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void SqrtException_Update()
        {
            var account = new CalcAccountTests();
            account.SqrtException_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void DividedByZeroException_Update()
        {
            var account = new CalcAccountTests();
            account.DividedByZeroException_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void LogException_Update()
        {
            var account = new CalcAccountTests();
            account.LogException_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void SyntaxException_Update()
        {
            var account = new CalcAccountTests();
            account.SyntaxException_Update();
            Assert.AreEqual();
        }
        [TestMethod]
        public void ArcSinCosException_Update()
        {
            var account = new CalcAccountTests();
            account.ArcSinCosException_Update();
            Assert.AreEqual();
        }
    }
}