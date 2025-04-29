using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using SimpleJSON;
using System.Collections;

public class cuaca_api : MonoBehaviour
{
    // UI elements to display weather data
    public TextMeshProUGUI locationText;
    public TextMeshProUGUI temperatureText;
    public TextMeshProUGUI minTemperatureText;
    public TextMeshProUGUI maxTemperatureText;
    public TextMeshProUGUI pressureText;
    public TextMeshProUGUI humidityText;
    public TextMeshProUGUI windspeedText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI statusText;

    private string apiKey = "ea9ca3ef3e10d8b2cdb7c4dad77529ec"; // Replace with your actual API key

    // Start is called before the first frame update
    void Start()
    {
        // Fetch the weather data when the scene starts
        StartCoroutine(FetchWeatherData());
    }

    private IEnumerator FetchWeatherData()
    {
        // Example coordinates for testing purposes (latitude and longitude)
        float lat = -6.923700f;
        float lon = 106.928726f;

        // Construct the OpenWeather API URL
        string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}&units=metric";

        // Send the request to the OpenWeather API
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        // Check if the request resulted in an error
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("Error fetching weather data: " + request.error);
            locationText.text = "Error fetching data";
        }
        else
        {
            // Parse the JSON response
            var response = JSON.Parse(request.downloadHandler.text);

            // Log the parsed JSON response for debugging
            Debug.Log("Parsed JSON response: " + response.ToString());

            // Check if the response contains necessary data
            if (response != null && response["main"] != null && response["wind"] != null && response["weather"] != null)
            {
                // Set the UI text elements with the weather data
                locationText.text = $"{response["name"]}, {response["sys"]["country"]}";
                descriptionText.text = $"Description: {response["weather"][0]["description"]}";
                temperatureText.text = $"Temperature: {response["main"]["temp"]} °C";
                minTemperatureText.text = $"Min Temperature: {response["main"]["temp_min"]} °C";
                maxTemperatureText.text = $"Max Temperature: {response["main"]["temp_max"]} °C";
                pressureText.text = $"Pressure: {response["main"]["pressure"]} hPa";
                humidityText.text = $"Humidity: {response["main"]["humidity"]}%";
                windspeedText.text = $"Wind Speed: {response["wind"]["speed"]} m/s";
                statusText.text = "Status: Data loaded successfully";
            }
            else
            {
                locationText.text = "Data not found";
                statusText.text = "Status: Failed to load data";
                Debug.LogWarning("Missing expected data in the response.");
            }
        }
    }
}
