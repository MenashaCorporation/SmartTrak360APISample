# SmartTrak360 API Consumer Sample App
Example application to show how to use SmartTrak360 API
1.	Open up the .sln in Visual Studio
2.	Open the app.config file
3.	Add the base URL for the environment you’re trying to access
4.	Add the ClientId provided in Mulesoft
5.	Add the Client Secret provided in Mulesoft
6.	Navigate to the Service folder and find the integration you want to implement
7.	The GetData() method is reading a sample JSON file in the project under the PostJSON folder
8.	This is the format your live data integration must be in to successfully post to the API
9.	You can use this file as an initial test or implement GetData to retrieve your live data and format it into the appropriate JSON
10.	Running the app can be done in the debugger
11.	Select the call you want to test and hit enter
12.	You can now debug your integration and verify the results in the website
13.	NOTE: Successful posts are processed every 15 minutes into the application. They may not be there right away
14.	Errors are displayed in the Admin & Planning module under the Import Errors menu
