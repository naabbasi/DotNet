@echo off
set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319

copy ..\..\lib\*.* work
..\..\bin\proxygen.exe work\myJavaDemoCalc.jar -wd work
cd work
call build.cmd
cd ..

echo compiling usage
csc.exe /nologo /warn:0 /reference:work\jni4net.n-0.8.9.0.dll /reference:work\myJavaDemoCalc.j4n.dll /out:work\demo.exe /target:exe MyCalcUsageInDotnet.cs
