# OpenBootcamp-Apis-Net

# Creating the Project
dotnet new globaljson --sdk-version 6.0.305 --output UnivercityApiBackend
dotnet new webapi --output UnivercityApiBackend --framework net6.0
dotnet new sln -n Univercity
dotnet sln Univercity.sln add UnivercityApiBackend.csproj

dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.7
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.7
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.7
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.7
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Desing --version 6.0.7
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Core --version 6.0.7

dotnet ef migrations add Initial 
dotnet ef database drop --force
dotnet ef database update
dotnet ef migrations script