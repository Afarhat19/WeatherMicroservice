# WeatherMicroservice
WeatherMicroservice361

Requesting Data: 

I have created a local API. This API is not hosted anywhere and only works when you run the API locally on your machine. Your browser should pop up and show a swagger page at the local host URL. The API only has one endpoint and it is a GET endpoint. It uses URL parameters to grab the data. Here is an example of some of the calls. 

(https://localhost:5001/WeatherForecast/35?israining=true) - Returns the string "Wear a winter coat at minimum."
(https://localhost:5001/WeatherForecast/5?israining=true) - Returns the string "Wear as many clothes as possible. Bring an umbrella."
(https://localhost:5001/WeatherForecast/45?israining=true) - Returns the string "Wear a hoodie or light jacket. Bring an umbrella."
(https://localhost:5001/WeatherForecast/15?israining=false) - Returns the string "Wear at least 4 layers with gloves and a hat."
(https://localhost:5001/WeatherForecast/-10?israining=true) - Returns a 400 Bad Request response with the message "Invalid temperature value." (since the temperature parameter is less than 0 and outside the expected range)

To effectively request this endpoint, make sure to pass the temperature parameter for the day in Fahrenheit. Additionally, you have the option to pass a boolean parameter ("IsRaining") to indicate whether it is raining or not. If the "IsRaining" parameter is not passed, my microservice will assume a default value of false. By calling this endpoint, you can expect to receive a string response that suggests appropriate actions to prepare for the weather. The following examples demonstrate the usage of this endpoint.

My API will return a 200 code and a string with whatever the recommendation is. 



![image](https://user-images.githubusercontent.com/68794174/237000587-4a92cfca-480b-4887-8305-06e3aa5e81de.png)

