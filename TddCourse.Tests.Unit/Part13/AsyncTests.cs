﻿using System.Threading.Tasks;
using NUnit.Framework;

namespace TddCourse.Tests.Unit.Part13
{
    [TestFixture]
    public class AsyncTests
    {
        [Test]
        public async void DivideAsyncTest()
        {
            var calculator = new Calculator();
            float quotient = await calculator.DivideAsync(10, 2);
            Assert.That(quotient, Is.EqualTo(5));
        }

        [Test]
        public async Task DivideAsyncLambdaTest()
        {
            var calculator = new Calculator();
            Assert.That(async () => await calculator.DivideAsync(10, 2), Is.EqualTo(5));
        }
    }
}