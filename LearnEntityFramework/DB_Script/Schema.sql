CREATE TABLE `qtime`.`languages`
(
    `lang_gkey` bigint       NOT NULL AUTO_INCREMENT,
    `name`      varchar(255) NOT NULL,
    `culture`   varchar(100) NOT NULL,
    PRIMARY KEY (`lang_gkey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `qtime`.`languages` (name, culture) VALUES ('en', 'PK');

CREATE TABLE `qtime`.`users`
(
    `user_gkey`     bigint       NOT NULL AUTO_INCREMENT,
    `username`      varchar(255) NOT NULL,
    `password`      varchar(255) NOT NULL,
    `language_gkey` bigint       NOT NULL,
    PRIMARY KEY (`user_gkey`),
    KEY `users_FK` (`language_gkey`),
    CONSTRAINT `users_FK` FOREIGN KEY (`language_gkey`) REFERENCES `languages` (`lang_gkey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;