using System;

namespace Module_18_patterns_part_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Task_18_1_6();
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

        static void ShowPrototype()
        {
            // создаем точку
            ILocation location = new Point(30.245, 40.954);
            // клонируем точку (получаем новую точку с теми же координатами)
            ILocation cloneLocation = location.Clone();

            location.GetInfo();
            cloneLocation.GetInfo();

            // создаем место
            location = new Place(" Улица Пушкина, дом Колотушкина");
            // клонируем место (полуаем новое место по тому же адресу)
            // пример использования - нам надо обозначить новый магазин в том же самом торговом центре
            cloneLocation = location.Clone();

            location.GetInfo();
            cloneLocation.GetInfo();
        }

        static void Task_18_1_6()
        {
            BaseClass myObject = new ImplementationOne(1);
            myObject.GetId();

            BaseClass clone = myObject.Clone();
            clone.GetId();

            myObject = new ImplementationTwo(2);
            myObject.GetId();

            clone = myObject.Clone();
            clone.GetId();
        }
    }
}
