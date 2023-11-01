@echo off
chcp 65001

rem サーバスタート
rem start "[Server] santafe.mightygumball.com" /d "..\ProxyServer\bin\Debug" ProxyServer.exe santafe.mightygumball.com 100
rem start "[Server] boulder.mightygumball.com" /d "..\ProxyServer\bin\Debug" ProxyServer.exe boulder.mightygumball.com 100
start "[Server] austin.mightygumball.com" /d "..\ProxyServer\bin\Debug" ProxyServer.exe austin.mightygumball.com 250

rem 立ち上がるまで適当な時間待つ
timeout /t 1

rem クライアントスタート
rem start "[Client] all" /d "..\ProxyClient\bin\Debug" ProxyClient.exe
start "[Client] austin.mightygumball.com" /d "..\ProxyClient\bin\Debug" ProxyClient.exe austin.mightygumball.com
