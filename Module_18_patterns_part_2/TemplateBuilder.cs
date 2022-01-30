using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_patterns_part_2
{
    /// <summary>
    /// Абстрактрный класс шаблонизатора (здесь он является строителем)
    /// </summary>
    abstract class TemplateBuilder
    {
        public Template Template { get; private set; }
        public void CreateTemplate()
        {
            Template = new Template();
        }

        // Метод для создания заголовка
        public abstract void BuildHeader();

        // Метод создания тела письма
        public abstract void BuildBody();

        // Метод создания футтера письма
        public abstract void BuildFooter();
    }
}
