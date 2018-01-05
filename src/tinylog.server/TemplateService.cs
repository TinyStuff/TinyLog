using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Newtonsoft.Json;

namespace tinylog.server
{
    public class TemplateService
    {
        private List<Template> _templates { get; set; }

        internal int AddTemplate(Template template)
        {
            return template.Id;
        }

    }
}
