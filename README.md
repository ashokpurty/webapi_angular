Host web api 
1.Download the repro in local system.
2. Open solution sln file with Vs2012 as solution is create using vs2012.Not sure but definitely it will work with 2012 higher version 
3. Copy the "RestfulWebApi" folder in "C:\inetpub\wwwroot" path  
2. Open IIS and add new website
3. Any name can be mentioned in site name and point the "Physical path" to the angular app e.g:
     C:\inetpub\wwwroot\RestfulWebApi
4. Application port number MUST BE 9009 as that is mentioned in angular web application.
5. Application should be running successfully and user should be able to browser the app app.
