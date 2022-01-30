using System;

namespace Module_18_patterns_part_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Task_18_1_1();
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

        static void Task_18_1_1()
        {

            // Объект завода, который будет заниматься производством
            var carPlant = new CarPlant();

            // производство скутеров
            Conveyor builder = new ScooterConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            // производство автомобилей
            builder = new CarConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            // производство мотоциклов
            builder = new MotoConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();
        }
    }
}
