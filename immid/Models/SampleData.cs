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
        }
    }
}
