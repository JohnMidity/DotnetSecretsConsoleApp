# DotnetSecretsConsoleApp
.Net 7

## To add your own secrets, local to your machine's user
Edit the file 

```%APPDATA%\Microsoft\UserSecrets\<UserSecretsId>\secrets.json```

Where ```<UserSecretsId>``` is the id specified in the project file

For example, set it to this to override the password from the appsettings.json
```
{
  "ConsoleCredentials": {
    "Password": "myPersonalSecret"
  }
}
```