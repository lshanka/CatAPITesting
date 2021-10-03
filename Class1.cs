using System;
using RestSharp;
using Newtonsoft.Json;

public  class TalkToCatAPI
{
	
	public CatsInformation[] TalkToCat()
	{
		//method steps:
		//talk to CATAPI webpage
		//gets the response as json
		//deseialise the json and store information as array of CatsInformation class
		//returns (array of CatsInformation class) 
		var client = new RestClient("https://api.thecatapi.com/v1/breeds");
		var request = new RestRequest(Method.GET);
		request.AddHeader("x-api-key", "8e14a33b-c328-43c0-8050-9517dec17f17");
		IRestResponse response = client.Execute(request);
		var resultFromAPI=response.Content;
		var catArray = JsonConvert.DeserializeObject<CatsInformation[]>(resultFromAPI);
		return (catArray);
	}
}