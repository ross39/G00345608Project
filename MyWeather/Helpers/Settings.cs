// Helpers/Settings.cs
using Xamarin.Essentials;

namespace MyWeather.Helpers
{
    /// <summary>
    /// This is the code for the settings
    /// 
    /// </summary>
    public static class Settings
    {

        #region Setting Constants

        private const string IsImperialKey = "is_imperial";
        private static readonly bool IsImperialDefault = true;

        //Initially set background to dark
        //private const string IsDarkBackground = "is_darkBackground";
       //private static readonly bool IsDarkBackgroundDefault = false;


        private const string UseCityKey = "use_city";
        private static readonly bool UseCityDefault = true;


        private const string CityKey = "city";
        private static readonly string CityDefault = "Galway";

        #endregion


        public static bool IsImperial
        {
            get => Preferences.Get(IsImperialKey, IsImperialDefault);
            set => Preferences.Set(IsImperialKey, value);
        }


        //public static bool IsDarkbackground
       // {
           //get => Preferences.Get(IsDarkBackground, IsDarkBackgroundDefault);
           // set => Preferences.Set(IsImperialKey, value);

       // }

        public static bool UseCity
        {
            get => Preferences.Get(UseCityKey, UseCityDefault);
            set => Preferences.Set(UseCityKey, value);
        }

        public static string City
        {
            get => Preferences.Get(CityKey, CityDefault);
            set => Preferences.Set(CityKey, value);
        }

    }
}