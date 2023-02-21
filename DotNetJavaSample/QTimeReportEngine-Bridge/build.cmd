@echo off
if not exist target mkdir target
if not exist target\classes mkdir target\classes

echo %JAVA_HOME%
echo compile classes
%JAVA_HOME%\bin\javac -nowarn -d target\classes -sourcepath jvm -cp "QTimeReportEngine-Bridge.jar";"spring-core-5.3.22.jar";"spring-beans-5.3.22.jar";"spring-context-5.3.22.jar";"..\..\jni4net-0.8.9.0\lib\jni4net.j-0.8.9.0.jar"; @sources.txt
IF %ERRORLEVEL% NEQ 0 goto end


echo QTimeReportEngine-Bridge.j4n.jar
%JAVA_HOME%\bin\jar cvf QTimeReportEngine-Bridge.j4n.jar  @classes.txt > nul
IF %ERRORLEVEL% NEQ 0 goto end


echo QTimeReportEngine-Bridge.j4n.dll
csc /nologo /warn:0 /t:library /out:QTimeReportEngine-Bridge.j4n.dll /recurse:clr\*.cs  /reference:"..\..\jni4net-0.8.9.0\lib\jni4net.n-0.8.9.0.dll"
IF %ERRORLEVEL% NEQ 0 goto end


:end
