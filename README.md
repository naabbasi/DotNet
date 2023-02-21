############## Define Global Imports ##############<br/>
Create a file Usings.cs in root of the project and add the following<br/>
<pre>
global using log4net;
</pre>
############## Entity Framework Core ##############
<pre>
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Abstractions
Install-Package Microsoft.EntityFrameworkCore.Relational
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Pomelo.EntityFrameworkCore.MySql
Install-Package System.Data.SqlClient
Install-Package log4net
</pre>

Create a file appsettings.config
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <connectionStrings>
    <add name="UserDBContext"
    connectionString="server=172.27.84.156;port=3306;database=qtime;user=qbill_dev;password=Qt@DeV"
    providerName="System.Data.SqlClient"/>
  </connectionStrings>  
</configuration>
```
<pre>
Scaffold-DbContext "server=172.27.84.156;port=3306;database=qtime;user=qbill_dev;password=Qt@DeV" Pomelo.EntityFrameworkCore.MySql -OutputDir Models -Context "UserDBContext" -DataAnnotations
</pre>
############## Log4Net ##############
Define the following into the Properties/AssemblyInfo.cs
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

Sample log4jnet.config
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <configSections>
    <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
  </configSections>

  <log4net>
    <root>
      <level value="ALL" />
      <appender-ref ref="console" />
      <appender-ref ref="file" />
    </root>
    <appender name="console" type="log4net.Appender.ConsoleAppender">
      <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%date %level %logger - %message%newline" />
      </layout>
    </appender>
    <appender name="file" type="log4net.Appender.RollingFileAppender">
      <file value="C:\\qterminals_config\\logs\\myapp.log" />
      <appendToFile value="true" />
      <rollingStyle value="Size" />
      <maxSizeRollBackups value="5" />
      <maximumFileSize value="10MB" />
      <staticLogFileName value="true" />
      <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%date [%thread] %level %logger - %message%newline" />
      </layout>
    </appender>
  </log4net>
</configuration>
```