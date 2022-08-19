using CinemaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CinemaApp.Model;
using System.Data.Entity;
using System.Threading;

namespace CinemaApp.Classes
{
    public class DatabaseClass
    {
        Core db = new Core();
        public bool CheckingConnection()
        {
            try
            {
                CinemaEntities cinemaEntities = new CinemaEntities();
                cinemaEntities.Database.Connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Не удалось подключиться к базе данных");
            }
          
        }
    }
}
