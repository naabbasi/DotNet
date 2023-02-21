dotnet new sln -o CloudCustomers
dotnet new webapi -o CloudCustomers.API
dotnet new xunit -o CloudCustomers.UnitTests

dotnet sln add .\CloudCustomers.API\ .\CloudCustomers.UnitTests\

"server=172.27.84.156;uid=qbill_dev;pwd=Qt@DeV;database=qbill"

dotnet ef dbcontext scaffold "server=172.27.84.156;uid=qbill_dev;pwd=Qt@DeV;database=qbill" MySql.EntityFrameworkCore -o qbil_base_user -f

Scaffold-DbContext "server=172.27.84.156;uid=qbill_dev;pwd=Qt@DeV;database=qbill" MySql.EntityFrameworkCore -OutputDir Models -t qbil_base_user
Scaffold-DbContext "server=172.27.84.156;uid=qbill_dev;pwd=Qt@DeV;database=qbill" MySql.EntityFrameworkCore -OutputDir Models -Tables qbil_base_user -f