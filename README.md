This .NET framework desktop app is really an exercise in utilizing APIs to make more effective and useful programs. 

In order for this to function properly on a local machine, you will need to add an API key into an App.config file in the solution. 
You can get your own API key at https://www.weatherapi.com/

The config file should look something like:
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
    </startup>
	<appSettings>
		<add key="apiKey" value="API KEY GOES HERE"/>
	</appSettings>
</configuration>
```
