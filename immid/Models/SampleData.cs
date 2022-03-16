namespace immid.Models
{
    public class SampleData
    {
        public static void Initialize(ProjectContext context)
        {
            //Если данных в бд нет
            if (!context.Projects.Any())
            {
                //Создаем три объекта
                context.Projects.AddRange(
                    new ProjectModel
                    {
                        Title = "iPhone X",
                        ShortDesc = "Apple",
                        LongDexc = "da"
                    },
                    new ProjectModel
                    {
                        Title = "Samsung Galaxy Edge",
                        ShortDesc = "Samsung",
                        LongDexc = "da"
                    },
                    new ProjectModel
                    {
                        Title = "Pixel 3",
                        ShortDesc = "Google",
                        LongDexc = "da"
                    }
                );
                context.SaveChanges();
            }
            if (!context.News.Any())
            {
                context.News.AddRange(
                    new NewsModel
                    {
                        Title = "Уникальное событие",
                        Desc = "ИДИ",
                        Category = "da"
                    },
                    new NewsModel
                    {
                        Title = "Открытие века",
                        Desc = "ДЕЛАЙ",
                        Category = "da"
                    },
                    new NewsModel
                    {
                        Title = "Ультра супер мега харош",
                        Desc = "ДИПЛОМ",
                        Category = "da"
                    }
                );
                context.SaveChanges();
            }
            if (!context.Events.Any())
            {
                context.Events.AddRange(
                    new EventModel
                    {
                        Title = "Уникальное событие",
                        Desc = "ЧИКИБАМБОНИ",
                        Category = "da"
                    },
                    new EventModel
                    {
                        Title = "Открытие века",
                        Desc = "ЧИКИБОМБАСТЕР",
                        Category = "da"
                    },
                    new EventModel
                    {
                        Title = "Ультра супер мега харош",
                        Desc = "ЧИКИБОМБОНИСТЕР",
                        Category = "da"
                    }
                );
                context.SaveChanges();
            }            
        }
    }
}
