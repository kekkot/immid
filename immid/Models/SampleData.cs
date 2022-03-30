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
            //Если данных в бд нет
            if (!context.News.Any())
            {
                //Создаем три объекта
                context.News.AddRange(
                    new NewsModel
                    {
                        Title ="Darova1",
                        Desc="Описание1",
                        Category="Новости",
                        Text="ДАДАДА"
                    },
                    new NewsModel
                    {
                        Title = "Darova2",
                        Desc = "Описание2",
                        Category = "Новости",
                        Text = "ДАДАДА"
                    },
                    new NewsModel
                    {
                        Title = "Darova3",
                        Desc = "Описание3",
                        Category = "Новости",
                        Text = "ДАДАДА"
                    }
                );
                context.SaveChanges();
            }
            //Если данных в бд нет
            if (!context.User.Any())
            {
                //Создаем три объекта
                context.User.AddRange(
                    new User
                    {
                        Email="Pushkina",
                        Name="Da",
                        Pas="123"
                    },
                    new User
                    {
                        Email = "DOM",
                        Name = "Da",
                        Pas = "123"
                    },
                    new User
                    {
                        Email = "Kolotushkina",
                        Name = "Da",
                        Pas = "123"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
