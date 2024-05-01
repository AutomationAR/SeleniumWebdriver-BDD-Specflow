using RestSharp;

var client = new RestClient("https://simple-books-api.glitch.me");

var request = new RestRequest("/books", Method.Get);

// Execute the request
RestResponse response = client.Execute(request);


if (response.IsSuccessful)
{
    // Handle successful response
    var content = response.Content;
  
}
else
{
    // Handle unsuccessful response
    var errorMessage = response.ErrorMessage;
}
