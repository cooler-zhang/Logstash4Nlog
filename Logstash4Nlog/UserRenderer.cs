using NLog;
using NLog.LayoutRenderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logstash4Nlog
{
    [LayoutRenderer("user")]
    public class UserRenderer : LayoutRenderer
    {
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            builder.Append("cooler.zhang");
        }
    }

    [LayoutRenderer("environment")]
    public class EnvironmentRenderer : LayoutRenderer
    {
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            builder.Append("test");
        }
    }
}
