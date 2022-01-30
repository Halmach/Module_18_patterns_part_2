using System;

namespace Module_18_patterns_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowBuilderPattern();
        }

        static void ShowBuilderPattern()
        {

            // создаем шаблонизатор для приветственной рассылки
            TemplateBuilder welcomeBulder = new WelcomeTemplateBuilder();
            OrderTemplateBuilder orderTemplateBuilder = new OrderTemplateBuilder();

            // создаем движок шаблонизатора
            TemplateEngine templateEngine = new TemplateEngine();

            // генерируем  приветственное письо с текстом
            Template greetings = templateEngine.GenerateTemplate(welcomeBulder);
            Console.WriteLine(greetings.ToString());

            // генерируем  письмо  с номером заказа
            Template ordering = templateEngine.GenerateTemplate(orderTemplateBuilder);
            Console.WriteLine(ordering.ToString());
        }
    }
}
