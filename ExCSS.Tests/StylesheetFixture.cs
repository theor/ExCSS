using System.Linq;
using NUnit.Framework;

namespace ExCSS.Tests
{
    [TestFixture]
    public class StylesheetFixture
    {
        [Test]
        public void Empty_stylesheet_does_not_throw_on_ToString()
        {
            var parser = new Parser();
            var styleSheet = parser.Parse(string.Empty);
            styleSheet.ToString();
        }

        [Test]
        public void Parse()
        {
            string css = @"#asd.a.b { color: #ff0 }
a b c#id.we {}
.ca.cb {}
.cc {}";

            var parser = new Parser();
            var styleSheet = parser.Parse(css);
            styleSheet.ToString();
        }
    }
}
