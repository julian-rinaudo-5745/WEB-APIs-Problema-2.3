using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_APIs_Problema_2._3.Models;

namespace WEB_APIs_Problema_2._3.Interfaces
{
    public interface IRegisterTempRepository
    {
        List<RegisterTemp> GetAll();

        List<RegisterTemp> GetByIOT(int iot);

        bool CreateTemp(RegisterTemp temp);
    }
}