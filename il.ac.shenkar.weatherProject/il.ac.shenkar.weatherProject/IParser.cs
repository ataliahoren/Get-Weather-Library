﻿namespace il.ac.shenkar.weatherProject
{
    /// <summary>
    /// This interface defines the ParseDocument method 
    /// and it's purpose is to get the data from a url address and parse it to weather object
    /// </summary>
    public interface IParser
    {
        /// <summary>
        /// Parses the document from the url address
        /// </summary>
        /// <returns> The weather data object after parsing </returns>
        WeatherData ParseDocument();
    }
}
