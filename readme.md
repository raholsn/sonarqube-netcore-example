# sonarqube-reproduction

Playing around with SonarQube is fun.

This is a very short guide to get started.

- Get sonarqube up by using the docker-compose.yml file. Big thanks to Warchant for providing one. (https://gist.github.com/Warchant/0d0f0104fe7adf3b310937d2db67b512 )
- Install sonarscanner from https://www.nuget.org/packages/dotnet-sonarscanner

Use following commands to analyis your project:

```
dotnet-sonarscanner begin /k:"project-key" 
```

This will basically make sonarscanner attach itself to the roslyn complier and monitors for any compiles.

```
dotnet build
```

The actual build

```
dotnet-sonarscanner end
```

This will detach sonarscanner and upload the results. <Br>
By default it will use http://localhost:9000

I've added a class lib called domain just to play around with.
