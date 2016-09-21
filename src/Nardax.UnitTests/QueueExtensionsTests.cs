using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Nardax.UnitTests
{
    [TestClass]
    public class QueueExtensionsTests
    {
        Queue<string> _queue;

        public void EnqueueRange()
        {
            _queue.EnqueueRange(new[] { "dd", "ee" });

            Assert.AreEqual("ee", _queue.Dequeue());
        }
    }
}
