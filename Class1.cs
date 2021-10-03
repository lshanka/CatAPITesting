using System;
using RestSharp;
using Newtonsoft.Json;

public  class TalkToCatAPI
{
	
	public CatsInformation[] TalkToCat()
	{
		/*method steps:
		talk to CATAPI webpage
		gets the response as json
		deseialise the json and store information as array of CatsInformation class
		returns (array of CatsInformation class) */

		//calling the CATAPI webpage through RestClient and sending a Get request
		var client = new RestClient("https://api.thecatapi.com/v1/breeds");
		var request = new RestRequest(Method.GET);

		//adding my API key in the HTML header section
		request.AddHeader("x-api-key", "8e14a33b-c328-43c0-8050-9517dec17f17");

		//getting a response from the CATAPI
		IRestResponse response = client.Execute(request);
		var resultFromAPI=response.Content;

		//deserialising the json content into array of type CatsInformation
		var catArray = JsonConvert.DeserializeObject<CatsInformation[]>(resultFromAPI);
		return (catArray);
	}
}