using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLog.Layouts;
using Xunit;

namespace NLog.Web.Tests.LayoutRenderers
{
    public class AssemblyVersionLayoutRendererTests : TestBase
    {
        [Fact]
        public void AssemblyNameVersionTest()
        {
            Layout l = "${assembly-version:NLog.Web.AspNetCore.Tests}";
            var result = l.Render(LogEventInfo.CreateNullEvent());
            Assert.Equal("1.2.3.0", result);
        }
    }
}
