rm -rf obj
rm -rf bin

dotnet build RF5_AutoFishing.csproj -f net6.0 -c Release

zip -j 'RF5_AutoFishing_v1.1.0.zip' './bin/Release/net6.0/RF5_AutoFishing.dll'