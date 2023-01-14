using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAndCal.Model;

namespace TAndCal.Utility
{
    public interface IUiPageTypeRepository
    {
       int CreateMethod(UiPageTypeModel UiPageTypeModel);
      List<UiPageTypeModel> GetAllUsers();
        UiPageTypeModel GetById(int id);
        int Update(UiPageTypeModel uiPageTypeModel);
        void Delete(UiPageTypeModel userTypeModel);
    }
}
