package com.qterminals.reporting;

public interface JasperReportEngine {
    void Run(String reportName);
    byte[] RunAndReturn(String reportName);
}
