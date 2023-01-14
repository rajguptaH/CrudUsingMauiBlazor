using SQLite;
using TAndCal.Model;
using TAndCal.Utility;

namespace TestingAndCalMobile.MVVM.Utility
{
    public class UiPageTypeRepository : IUiPageTypeRepository
    {
        private SQLiteConnection _connection;
        public UiPageTypeRepository()
        {
            SetupDb();
        }
        private  void SetupDb()
        {
            if (_connection == null)
            {
                _connection = new SQLiteConnection(DbConnection.DbPath, DbConnection.Flags);
            }
        }
        public  int  CreateMethod(UiPageTypeModel UiPageTypeModel)
        {
            try
            {
              return _connection.Insert(UiPageTypeModel);
                 
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public List<UiPageTypeModel> GetAllUsers()
        {
           return  _connection.Table<UiPageTypeModel>().ToList();
             
        }
        public UiPageTypeModel GetById(int id)
        {
           return _connection.Query<UiPageTypeModel>($"Select * From {nameof(UiPageTypeModel)} where Id = {id}").First();
             
        }
        public  int Update(UiPageTypeModel uiPageTypeModel)
        {
            return _connection.Update(uiPageTypeModel);
        }
        public void Delete(UiPageTypeModel uiPageTypeModel)
        {
            _connection.Delete(uiPageTypeModel);
            
        }
    }
}
