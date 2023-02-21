package com.qterminals.reporting;

import com.qterminals.report.engine.ReportEngine;

public class JasperReportEngineImpl implements JasperReportEngine {

    @Override
    public void Run(String reportName) {
        ReportEngine reportEngine = new ReportEngine();
        reportEngine.GenerateReport();
    }

    @Override
    public byte[] RunAndReturn(String reportName) {
        ReportEngine reportEngine = new ReportEngine();
        return reportEngine.GetGeneratedReport();
    }
}
