using System;
using System.Collections.Generic;
using System.Text;

namespace ExploreTrips.DataStorage
{
    using SQLitePCL;
    using System.IO;

    public class SQLiteHandler
    {
        public SQLite.SQLiteAsyncConnection Connection { get; set; }

        public SQLiteHandler()
        {
            string dbName = "TripsSaved.db3";
            string direction = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.iOS)
            {
                direction = Path.Combine(direction, "..", "Library");
            }
            direction = Path.Combine(direction, dbName);

            try
            {
                Connection = new SQLite.SQLiteAsyncConnection(direction);
            }
            catch (Exception)
            {

            }
        }

        public async void InitTablesAsync()
        {
            if (Connection!=null)
            {
                await Connection.CreateTableAsync<Models.BookingDestination>();
            }
        }

    }
}
