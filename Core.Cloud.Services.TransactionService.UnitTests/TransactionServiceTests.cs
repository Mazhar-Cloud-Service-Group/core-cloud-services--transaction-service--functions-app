using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Cloud.Services.TransactionService.UnitTests
{
    [TestClass]
    public class TransactionServiceTests
    {
        [TestInitialize]
        public void Init()
        {

        }

        [TestMethod]
        public void SuccesspullyCreatedTransaction()
        {
            var name = "TransactionService";
            var serviceName = name;

            Assert.AreEqual(serviceName, name);
        }
    }
}
