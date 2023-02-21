Create database and add the following Tables

```
CREATE DATABASE qtime;

USE qtime;

-- qtime.languages definition

CREATE TABLE `languages` (
  `lang_gkey` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `culture` varchar(100) NOT NULL,
  PRIMARY KEY (`lang_gkey`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- qtime.users definition

CREATE TABLE `users` (
  `user_gkey` bigint NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `language_gkey` bigint NOT NULL,
  PRIMARY KEY (`user_gkey`),
  KEY `users_FK` (`language_gkey`),
  CONSTRAINT `users_FK` FOREIGN KEY (`language_gkey`) REFERENCES `languages` (`lang_gkey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- qtime.culture_messages definition

CREATE TABLE `culture_messages` (
  `culture_message_gkey` bigint NOT NULL AUTO_INCREMENT,
  `language_gkey` bigint NOT NULL,
  `key` varchar(255) NOT NULL,
  `value` text NOT NULL,
  PRIMARY KEY (`culture_message_gkey`),
  CONSTRAINT `culture_messages_FK` FOREIGN KEY (`culture_message_gkey`) REFERENCES `languages` (`lang_gkey`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

Add the following in appsettings.json
```
{
  "ConnectionStrings": {
    "QRoasterDBConnection": "server=172.27.84.156;port=3306;database=qtime;user=qbill_dev;password=Qt@DeV"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

Install the following packages

```
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.Data.SqlClient
Install-Package Pomelo.EntityFrameworkCore.MySql
```

<pre>
Scaffold-DbContext -Connection name=QRoasterDBConnection -Provider Pomelo.EntityFrameworkCore.MySql -OutputDir "Models" -ContextDir "DBContext" -Context "QRoasterDBContext" -NoOnConfiguring -DataAnnotations
</pre>