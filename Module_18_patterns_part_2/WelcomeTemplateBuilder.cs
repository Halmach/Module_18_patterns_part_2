using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_patterns_part_2
{
    class WelcomeTemplateBuilder : TemplateBuilder
    {
        public override void BuildBody()
        {
            Template.Body = new Body { Text = "Спасибо за регистрацию в нашем приложении" };
        }

        public override void BuildFooter()
        {
            // не используется
        }

        public override void BuildHeader()
        {
            Template.Header = new Header { Text = "Здравствуйте!" };
        }
    }
}
