package com.qterminals.db;

import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Map;

public class SqlUtils {
    /*public ResultSet getResultSet(Connection connection, String sqlFileName, Map<Integer,Object> params) {
        try {
            List<String> lines = Files.readAllLines(Path.of(sqlFileName), StandardCharsets.UTF_16);

            String sqlQuery = lines.stream().map(Object::toString).collect(Collectors.joining(""));
            PreparedStatement preparedStatement = connection.prepareStatement(sqlQuery);

            for(Map.Entry<Integer, Object> param : params.entrySet()){
                preparedStatement.setObject(param.getKey(), param.getValue());
            }

            ResultSet resultSet = preparedStatement.executeQuery();
            return resultSet;
        } catch (IOException e) {
            throw new RuntimeException(e);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }*/

    public ResultSet getResultSetByQuery(Connection connection, String sqlQuery, Map<Integer,Object> params) throws SQLException {
        PreparedStatement preparedStatement = connection.prepareStatement(sqlQuery);

        for(Map.Entry<Integer, Object> param : params.entrySet()){
            preparedStatement.setObject(param.getKey(), param.getValue());
        }

        //param = Enum.valueOf((Class<? extends Enum>)dbField.getField().getType(), (String) param);
        ResultSet resultSet = preparedStatement.executeQuery();
        return resultSet;
    }

    public Boolean executeQuery(Connection connection, String sqlQuery, Map<Integer,Object> params) throws IOException, SQLException {
        PreparedStatement preparedStatement = connection.prepareStatement(sqlQuery);

        for(Map.Entry<Integer, Object> param : params.entrySet()){
            preparedStatement.setObject(param.getKey(), param.getValue());
        }

        return preparedStatement.execute();
    }

    public int execute(Connection connection, String sqlQuery, Map<Integer,Object> params) throws SQLException {
        PreparedStatement preparedStatement = connection.prepareStatement(sqlQuery);

        for(Map.Entry<Integer, Object> param : params.entrySet()){
            preparedStatement.setObject(param.getKey(), param.getValue());
        }

        return preparedStatement.executeUpdate();
    }
}
