using SQLite;

namespace TestingAndCalMobile.MVVM.Utility
{
    public static class DbConnection
    {
        private const string DbFileName = "Raj.db";
        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;
        public static string DbPath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DbFileName);
            }
        }
    }
}
