// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.NumberObjects
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheNumberConstructorCalledAsAFunctionTests : SputnikTestFixture
    {
        public TheNumberConstructorCalledAsAFunctionTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.7_Number_Objects\15.7.1_The_Number_Constructor_Called_as_a_Function")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.7.1.1")]
        [TestCase("S15.7.1.1_A1.js", Description = "Number([value]) returns a number value (not a Number object) computed by ToNumber(value) if value was supplied")]
        public void NumberValueReturnsANumberValueNotANumberObjectComputedByToNumberValueIfValueWasSupplied(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.7.1.1")]
        [TestCase("S15.7.1.1_A2.js", Description = "Number() returns +0")]
        public void NumberReturns0(string file)
        {
            RunFile(file);
        }
    }
}