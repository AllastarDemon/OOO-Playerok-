namespace VideoGamesStore.Classes
{
    internal class Helper
    {
        public static Database.PlayerokEntities3 DB = new Database.PlayerokEntities3();
        public static Database.User user { get; set; }
        public static Database.Developer developer { get; set; }
        public static Database.Category category { get; set; }
    }
}
