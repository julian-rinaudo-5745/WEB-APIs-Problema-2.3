using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_APIs_Problema_2._3.Interfaces;
using WEB_APIs_Problema_2._3.Models;

namespace WEB_APIs_Problema_2._3.Repository
{
    public class RegisterTempRepository : IRegisterTempRepository
    {
        private static RegisterTempRepository instance;
        private List<RegisterTemp> temps;

        private RegisterTempRepository()
        {
            temps = new List<RegisterTemp>();
        }

        public static RegisterTempRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new RegisterTempRepository();
            }

            return instance;
        }

        public List<RegisterTemp> GetAll()
        {
            return temps;
        }

        public List<RegisterTemp> GetByIOT(int iot)
        {
            return temps.FindAll(temp => temp.IOT == iot);
        }

        public bool CreateTemp(RegisterTemp temp)
        {
            bool result = false;

            temps.Add(temp);

            RegisterTemp? registeredTemp = temps.Find(t => t.IOT == temp.IOT);

            if (registeredTemp != null)
            {
                result = true;
            }

            return result;
        }
    }
}