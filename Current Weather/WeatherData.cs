namespace WeatherAppUsingApi
{
    internal class WeatherData
    {
        public string cityName { get; set; }        //name
        public string countryName { get; set; }     //country
        public string regionName { get; set; }      //region
        public string timeCurrently { get; set; }   //localtime
        public string temperature {  get; set; }    //temp_f
        public string windSpeed { get; set; }       //wind_mph
        public string windDirection { get; set; }   //wind_dir
        public string tempFeelsLike { get; set; }   //feelslike_f
        public string humidity { get; set; }        //humidity
        public string iconUrl { get; set; }         //icon
    }
}
