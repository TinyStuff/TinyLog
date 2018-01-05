using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using Xunit;

namespace tinylog.server.test
{
    public class UnitTest1
    {
        [Fact]
        public void AddTemplateToStore()
        {
            var obj = new Template();

            obj.Name = "MyTemplate";
            obj.Id = 42;

            obj.TemplateProperties = new List<TemplateProperty>
            {
                new TemplateProperty
                {
                    key = "logText",
                    type = "string"
                },

                new TemplateProperty
                {
                    key = "timeStamp",
                    type = "datetime"
                }
            };

            var s = new TemplateService();
            
            var result = s.AddTemplate(obj);
            
            Assert.True(result == 42);

        }


        [Fact]
        public void LogText()
        {
            var obj = new Template();

            obj.Name = "MyTemplate";
            obj.Id = 42;

            obj.TemplateProperties = new List<TemplateProperty>
            {
                new TemplateProperty
                {
                    key = "logText",
                    type = "string"
                },

                new TemplateProperty
                {
                    key = "timeStamp",
                    type = "datetime"
                }
            };

            var s = new TemplateService();
            

            var instance = new LoggerInstance(s);

            instance.ReceievedLogText += new LoggerInstance.ReceievedLogTextHandler(TestLogger.DebugWrite);
            var logString = "42,Hjaaaaeeeellp maj," + DateTime.Now;
            instance.LogText(logString);

            Assert.True(logString == TestLogger.result);

        }

    }

    internal class TestLogger
    {
        internal static string result { get; set; }
        internal static void DebugWrite(LoggerInstance l, ReceivedLogEventArgs e)
        {
            result = e.logText;
                
        }
        
    }
}