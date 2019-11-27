@ECHO OFF
SET /P KeyFile="Enter the full path: "

MSBuild.exe .\ExtMap.MSBuild.Tools.sln /t:Rebuild /p:Configuration=Release /p:Platform="Any CPU" /p:AssemblyOriginatorKeyFile="%KeyFile%" /fl