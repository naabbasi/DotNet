package com.qterminals;

import com.qterminals.reporting.JasperReportEngine;
import com.qterminals.reporting.JasperReportEngineImpl;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class LaunchApp {
    public static void main(String[] args) {
        SpringApplication.run(LaunchApp.class, args);

        JasperReportEngine jasperReportEngine = new JasperReportEngineImpl();
        jasperReportEngine.Run("Test");
    }
}
