# BTM - Bash the Movie

A small student project meant to represent a fun .NET, .NET Core and Xamarin application inspired by [IMDb](https://www.imdb.com/). 

Use the following to log into the Desktop app (the admin panel):

Username: `root`
Password: `root`

The Xamarin app is made specifically for users rather than administrators, but they can log in, too. Login info of a normal user is:

Username: `arman`
Password: `root`

## Quick start

Get a license key for [Syncfusion](https://www.syncfusion.com/) and add the following line of code in the constructor of `BTM.MobileApp/BTM.MobileApp/App.xaml.cs`:

```csharp
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOURLICENSEKEYHERE");
```

Afterwards, build the solution (it should also restore the NuGet packages) and run the app(s).

### Small preview of the login form

![](https://raw.githubusercontent.com/TheDoomKing/BTM/master/Preview.png "Login form preview")