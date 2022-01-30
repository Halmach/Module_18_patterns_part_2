using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_patterns_part_2
{
    /// <summary>
    /// Строитель для создания рассылки о заказе
    /// </summary>
    class OrderTemplateBuilder : TemplateBuilder
    {
        public override void BuildBody()
        {
            this.Template.Body = new Body { Text = "Ваш номер заказа - 534" };
        }

        public override void BuildFooter()
        {
            this.Template.Footer = new Footer() { Text = "OOO ЛучшийСервис, contact@bestservice.ru" };
        }

        public override void BuildHeader()
        {
            Template.Header = new Header { Text = "Здравствуйте, спасибо за заказ!" };
        }
    }
}
