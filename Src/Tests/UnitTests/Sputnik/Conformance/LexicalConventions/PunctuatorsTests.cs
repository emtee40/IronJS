// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.LexicalConventions
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PunctuatorsTests : SputnikTestFixture
    {
        public PunctuatorsTests()
            : base(@"Conformance\07_Lexical_Conventions\7.7_Punctuators")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.7")]
        [TestCase("S7.7_A1.js", Description = "Correct interpretation of all punctuators")]
        public void CorrectInterpretationOfAllPunctuators(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.7")]
        [TestCase("S7.7_A2_T1.js", Description = "Punctuator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \\u plus four hexadecimal digits", ExpectedException = typeof(Exception))]
        [TestCase("S7.7_A2_T10.js", Description = "Punctuator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \\u plus four hexadecimal digits", ExpectedException = typeof(Exception))]
        [TestCase("S7.7_A2_T2.js", Description = "Punctuator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \\u plus four hexadecimal digits", ExpectedException = typeof(Exception))]
        [TestCase("S7.7_A2_T3.js", Description = "Punctuator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \\u plus four hexadecimal digits", ExpectedException = typeof(Exception))]
        [TestCase("S7.7_A2_T4.js", Description = "Punctuator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \\u plus four hexadecimal digits", ExpectedException = typeof(Exception))]
        [TestCase("S7.7_A2_T5.js", Description = "Punctuator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \\u plus four hexadecimal digits", ExpectedException = typeof(Exception))]
        [TestCase("S7.7_A2_T6.js", Description = "Punctuator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \\u plus four hexadecimal digits", ExpectedException = typeof(Exception))]
        [TestCase("S7.7_A2_T7.js", Description = "Punctuator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \\u plus four hexadecimal digits", ExpectedException = typeof(Exception))]
        [TestCase("S7.7_A2_T8.js", Description = "Punctuator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \\u plus four hexadecimal digits", ExpectedException = typeof(Exception))]
        [TestCase("S7.7_A2_T9.js", Description = "Punctuator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \\u plus four hexadecimal digits", ExpectedException = typeof(Exception))]
        public void PunctuatorCannotBeExpressedAsAUnicodeEscapeSequenceConsistingOfSixCharactersNamelyUPlusFourHexadecimalDigits(string file)
        {
            RunFile(file);
        }
    }
}