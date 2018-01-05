using System;
using System.Collections.Generic;

namespace tinylog.server
{
    public class Template
    {
        public List<TemplateProperty> TemplateProperties { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TemplateProperty
    {
        public string key { get; set; }
        public string type { get; set; }
    }
}
