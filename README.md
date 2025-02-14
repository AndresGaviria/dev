# Commandos git 
- git clone URL 

- git fetch
- git pull

- git add *
- git commit -am "Descripcion"
- git push

- git branch dev1
- git checkout dev1
- git push -u origin dev1

- git checkout main
- git rebase main
- Remover si hay error la carpeta rebase-merge en \.git
- git commit -am "Descripcion"
- git push origin HEAD:main

- git checkout -- .

- Remover todo lo de github
- Control Panel\User Accounts\Credential Manager

# Commandos dotnet 
- dotnet run
- dotnet test
- dotnet restore
- dotnet add package NAME --version NUMBER
- dotnet remove package NAME

- dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.20
- dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.20
- dotnet add package Microsoft.Data.SqlClient --version 5.2.2
- dotnet add package Newtonsoft.Json --version 13.0.3
- dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 6.0.33
- dotnet add package Swashbuckle.AspNetCore --version 6.2.3
- dotnet add package Moq --version 4.20.71

- dotnet remove package Microsoft.Data.SqlClient

# Proyectos
    -Library
    dotnet new classlib -n lib_entities
    -WPF
    dotnet new wpf -n wpf_presentation
    -ASP NET CORE WEB API
    dotnet new webapi -n asp_service
    -ASP NET CORE Razor pages
    dotnet new webapp -n asp_presentation
    -UNIT TEST MSTEST
    dotnet new mstest -n mst_unittest
    -WINDOWS WORKER
    dotnet new worker -n srw_presentation
    -SQLSERVER
    dotnet new sqlproj -n db_presentation
    -MAUI
    dotnet new maui -n maui_presentation
    dotnet workload restore

    dotnet workload list
    dotnet workload install maui-android
    
    dotnet build -t:Run -f:net8.0-windows
    dotnet build -t:Run -f:net8.0-android
