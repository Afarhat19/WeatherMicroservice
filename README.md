# WeatherMicroservice
WeatherMicroservice361

Requesting Data: 

I have created a local API. This API is not hosted anywhere and only works when you run the API locally on your machine. Your browser should pop up and show a swagger page at the local host URL. The API only has one endpoint and it is a GET endpoint. It uses URL parameters to grab the data. Here is an example of some of the calls. 

(https://localhost:5001/WeatherForecast/35?israining=true) - Returns the string "Wear a winter coat at minimum."
(https://localhost:5001/WeatherForecast/5?israining=true) - Returns the string "Wear as many clothes as possible. Bring an umbrella."
(https://localhost:5001/WeatherForecast/45?israining=true) - Returns the string "Wear a hoodie or light jacket. Bring an umbrella."
(https://localhost:5001/WeatherForecast/15?israining=false) - Returns the string "Wear at least 4 layers with gloves and a hat."
(https://localhost:5001/WeatherForecast/-10?israining=true) - Returns a 400 Bad Request response with the message "Invalid temperature value." (since the temperature parameter is less than 0 and outside the expected range)

Basically to get data, you must input the temperature that day in fahrenheit and optionally input whether its raining or not. It defaults to false if it's not included. My API will perform some logic and return a string of what the user should do to prepare for the weather. The above are some examples of the endpoint being used. 

My API will return a 200 code and a string with whatever the recommendation is. 



![image](https://user-images.githubusercontent.com/68794174/237000587-4a92cfca-480b-4887-8305-06e3aa5e81de.png)

