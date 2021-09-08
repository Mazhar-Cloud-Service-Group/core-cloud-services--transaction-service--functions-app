using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Cloud.Services.TransactionService.UnitTests
{
    [TestClass]
    public class CreateTransactionTests
    {
        [TestInitialize]
        public void Initialize()
        {

        }

        [TestMethod]
        public void GiveValidInputs_WhenFunctionsRuns_ThenreturnOkResults()
        {
            var varFirst = "First";

            var varSecond = varFirst;

            // Assert
            Assert.AreEqual(varSecond, varFirst);
        }
    }
}
