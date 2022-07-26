if cannot use add-migration:
In appsettings.json, in "DefaultConnection" remove the final part "MultipleActiveResultSets = true"
In the package manager console (PowerShell), and having installed "Dotnet":
a) dotnet tool uninstall --global dotnet-ef (To Remove it only if it exists)
b) dotnet tool install --global dotnet-ef (To Install it if it does not exist)
c) dotnet ef (To see that it is installed correctly)
d) dotnet ef migrations add InitialCreate
e) dotnet ef database update
