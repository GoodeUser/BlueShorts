# Things to do
1. Create a class called “Location” in the Models folder with the following properties:
	- A text property called “Name”
	- A date property called “Localtime”. Casing here matters so the name of the properties should match exactly.
1.  Add a property to the “Weather” class with the type you just created and name it “Location”.
1.  Inside the “Data” folder there is a class called “WeatherRepository” that has a method named “GetWeatherForecast” which currently just returns some fake data. Instead of returning the fake data, make the method perform an HTTP GET request to the URL below and be sure to replace the query string parameter named “q” with the location that the user entered. Return the response as the “Weather” type and make the method “async”.
    -  [http://api.weatherapi.com/v1/forecast.json?key=2116719381ce4995bb922008222505&q=[location]&days=2&aqi=no&alerts=no](http://api.weatherapi.com/v1/forecast.json?key=2116719381ce4995bb922008222505&q=%5Blocation%5D&days=2&aqi=no&alerts=no)
    - Run the console application and verify that it outputs data from the location provided.
1.  Extract the WeatherRepository class to an interface and use the interface in the WeatherService instead of the actual implementation.
1.  Create a class named HotDay and another class named ColdDay. These classes are going to share a base class which you can name whatever you’d like.
    - The base class should have a method named “ShowMessage”.
    - The HotDay class will log out the hottest hour of the day when the “ShowMessage” method is called using the following message format: “The hottest hour of the day will be [hottest hour: eg. 1 PM] with a temperature of [temperature for the hottest hour] degrees Fahrenheit.
    - The ColdDay class will log out the coldest hour of the day when the “ShowMessage” method is called using the following message format: “The coldest hour of the day will be [coldest hour: eg. 1 PM] with a temperature of [temperature for the coldest hour] degrees Fahrenheit.
    - Using the data for the first day in the “Forecast” list and if the highest temperature for the day is over 80 degrees, then you should create a HotDay class. Otherwise, you should create a ColdDay class. Call the “ShowMessage” method and ensure that it logs what you would expect.
