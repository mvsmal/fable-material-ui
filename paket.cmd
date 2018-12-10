SET TOOL_PATH=.paket

IF NOT EXIST "%TOOL_PATH%\paket.exe" (
  dotnet tool install Paket --tool-path ./%TOOL_PATH%
)

"%TOOL_PATH%/paket.exe" %*
