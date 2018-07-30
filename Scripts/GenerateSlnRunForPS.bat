@echo off
color 1F
echo.

C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe -ExecutionPolicy Bypass -File "GenerateSln.ps1" WebProjectName

:EOF
echo Waiting seconds
timeout /t 10 /nobreak > NUL


