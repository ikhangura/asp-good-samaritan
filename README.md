# asp-good-samaritan

#API
Route: POST /api/Reports
Body: <br>
````json
{
  'year':String,
  'month':String,
}
````
Body On Reply: <br>
````json
{
    "$id": "1",
    "status": {
        "open": "0",
        "closed": "0",
        "reopened": "2"
    },
    "program": {
        "crisis": "0",
        "court": "0",
        "smart": "2",
        "dvu": "0",
        "mcfd": "0"
    },
    "gender": {
        "female": "1",
        "male": "1",
        "trans": "0"
    },
    "age": {
        "adult": "2",
        "youth1825": "0",
        "youth1219": "0",
        "child": "0",
        "senior": "0"
    }
}
````
#How to Authenticate with the API
There are a couple of calls you will need to do so as to be able to successfuly call the api routes. You will also need some additional headers in all of your calls. These can be easily added in angular

##Step 1: Get Username and Password from user
You'll have to ask the user to confirm thier login to generate the report as you need the username nad password to get the token. This can be done in your angular, you'll have to create a form to take the user's information
##Step 2: Get Auth Token from the API
This part gets a little tricky as I have found 3 different ways to call this and I only got one working in POSTman. It could be different in angular aswell.<br>
###The Call
Route: POST /Token <br>
####METHOD 1
This is done using jQuery and worked in POSTman
````js
var login = function(){
  var url = "/Token";
  var data = ('#formId").serielize();
  data = data + "&grant_type=password";
  $.post(url, data).success(saveAccessToken)
}
````
In the end though you need to come up with a call that will look something like this as plain text in the body:
`grant_type=password&username=adam%40gs.ca&password=P@$$w0rd`
This is what i passed in the body of my POSTman call. The above code is most likely to generate this. You will need to experiment and tweak


####METHOD 2
This is from a Microsoft Tutorial, it did not seem to work though. Simply add this to the body of your call
````json
{
  grant_type: "password",
  username : "<theusername>",
  password : "<thepassword>"
}
````
<hr>
###The Headers
For all of these calls aswell, so that you get the appropriate response, you should add the following headers to your calls. This can be done in angular by editing the $http.config and adding the headers like this:
````javascript
var config = {headers:  {
        'Content-Type' : 'application/json',
        'X-Requested-With' : 'XMLHttpRequest'
    }
};

$http.post("http://w11a.thunderchicken.ca/Token", config); //an example call using the set headers
````
These headers may by default be added by angular, but I had to add them in postman for anything to work

If the call is successful you will get a json object back containing an attribute named `access_token`. You need to keep this token as if your life depends on it as it is required for all calls made to the api. Save it as a global variable somewhere
````javascript
var accessToken;

$http.post("http://w11a.thunderchicken.ca/Token", config).then(onSuccess, onError);

var onSuccess = function(response){
  accessToken = response.access_token;
}
var onError = function(response){
  alert(JSON.stringify(response)); //for dev purposes
  //notify user thier username / password is incorrect
}
````

##Step 3: Call the Reports Route with Authentication Token
Now you can call the reports route, but again you will need to include extra headers in your call so that you pass validation. The headers should look like this in angular
````javascript
var config = {headers:  {
        'Content-Type' : 'application/json',
        'X-Requested-With' : 'XMLHttpRequest',
        'Authorization' : 'Bearer' + accesToken //the access token you got in step three with the word 'Bearer' infront of it
    }
};

$http.post("http://w11a.thunderchicken.ca/api/Reports", config) //an example call using the set headers
````
If your call is successful and the user token is valid, you will get the response stated earlier form the API for the route

