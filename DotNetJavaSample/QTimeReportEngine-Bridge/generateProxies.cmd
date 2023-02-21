@echo off
set CURRENT_DIRECTORY=%cd%

echo %CURRENT_DIRECTORY%
echo %JAVA_HOME%

echo Delete dotnet-proxies directory
if exist dotnet-proxies rmdir /S /Q dotnet-proxies

if not exist dotnet-proxies mkdir dotnet-proxies

cd ..
cd QTimeReportEngine
call mvn clean install -U
copy target\QTimeReportEngine.jar %CURRENT_DIRECTORY%\dotnet-proxies\
copy target\lib\*.jar %CURRENT_DIRECTORY%\dotnet-proxies\

cd ..
cd QTimeReportEngine-Bridge
call mvn clean install -U

copy ..\jni4net-0.8.9.0\lib\*.* dotnet-proxies
copy target\QTimeReportEngine-Bridge.jar dotnet-proxies

REM This is working fine without QTimeReportEngine-Bridge.proxygen.xml file
call ..\jni4net-0.8.9.0\bin\proxygen.exe dotnet-proxies\QTimeReportEngine-Bridge.jar -cp dotnet-proxies\spring-context-5.3.22.jar -wd dotnet-proxies

REM copy QTimeReportEngine-Bridge.proxygen.xml dotnet-proxies

REM call ..\jni4net-0.8.9.0\bin\proxygen.exe dotnet-proxies\QTimeReportEngine-Bridge.proxygen.xml -wd dotnet-proxies

copy build.cmd dotnet-proxies

set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319
cd dotnet-proxies
call build.cmd
cd %CURRENT_DIRECTORY%
