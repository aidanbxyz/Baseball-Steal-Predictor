@echo off
title BASEBALL STEAL PREDICTOR INSTALL
echo DOWNLOADING NEEDED FILES..
powershell -executionpolicy bypass -Command "(New-Object Net.WebClient).DownloadFile('https://github.com/aidanbxyz/Baseball-Steal-Predictor/raw/master/bin/Debug/stealpredictor.exe', 'stealpredictor.exe')"
powershell -executionpolicy bypass -Command "(New-Object Net.WebClient).DownloadFile('https://github.com/aidanbxyz/Baseball-Steal-Predictor/raw/master/font.ttf', 'font.ttf')"
cls
echo ^|=========================^|
echo ^|Baseball Steal Predictor ^|
echo ^|Installation Instructions^|
echo ^|=========================^|
echo.
echo :^>starting font.ttf
start font.ttf
echo.
echo 1. Click the "Install" button on the top left of the Veteran Typewriter Font Installation Window.
echo.
echo 2. Close the Font Installation Window after font is installed.
echo.
timeout 2 >nul
:checkfwinopen
timeout 1 >nul
tasklist /FI "IMAGENAME eq fontview.exe" 2>NUL | find /I /N "fontview.exe">NUL
if "%ERRORLEVEL%"=="0" goto checkfwinopen
cls
echo ^|=========================^|
echo ^|Baseball Steal Predictor ^|
echo ^|Installation Instructions^|
echo ^|=========================^|
echo.
echo :^>starting font.ttf
echo.
echo 1. Click the "Install" button on the top left of the Veteran Typewriter Font Installation Window.
echo.
echo 2. Close the Font Installation Window after font is installed.
echo.
echo :^>starting stealpredictor.exe
echo.
echo Starting the program in 5 seconds. Press any key to start sooner.
timeout 5 >nul
start stealpredictor.exe
echo PROGRAM STARTED.
timeout 2 >nul
exit