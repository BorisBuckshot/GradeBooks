using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2017, 6, 17);
            DateTime date2 = date;
            date2 =  date.AddDays(1);

            Assert.AreEqual(date2, date);
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book1);

            Assert.AreEqual(book1.Name, book2.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }



        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Scott's grade book";

            Assert.AreEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference2()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
   
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
