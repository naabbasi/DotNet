package com.qterminals.db;

import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.Properties;

public class MySQLDataSource {
    private static final Properties properties = new Properties();

    static {
        try {
            properties.load(MySQLDataSource.class.getResourceAsStream("/db.properties"));
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    public Connection getConnection() {
        Connection connection;
        try {
            Class.forName(getDriverClassName());
            connection = DriverManager.getConnection(getURL(), getUsername(), getPassword());
        } catch (ClassNotFoundException e) {
            throw new RuntimeException(e);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }

        return connection;
    }

    public void close(Connection connection){
        try {
            if(connection != null){
                connection.close();
                connection = null;
            }
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    private String getDriverClassName() {
        return properties.getProperty("report.engine.database.driverClassName");
    }

    private String getURL() {
        return properties.getProperty("report.engine.database.url");
    }

    private String getUsername() {
        return properties.getProperty("report.engine.database.username");
    }

    private String getPassword() {
        return properties.getProperty("report.engine.database.password");
    }
}
