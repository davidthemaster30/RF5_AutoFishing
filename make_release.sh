rm -rf obj
rm -rf bin

CSPROJ_PATH="RF5_AutoFishing.csproj"          # path to your .csproj

dotnet build $CSPROJ_PATH -f net6.0 -c Release

VERSION=$(grep -oP '(?<=<Version>)[^<]+' "$CSPROJ_PATH" || true)
PROJECT_NAME=$(grep -oP '(?<=<AssemblyName>)[^<]+' "$CSPROJ_PATH" || true)
ZIP_NAME="$PROJECT_NAME_v$VERSION.zip"

zip -j "$ZIP_NAME" './bin/Release/net6.0/RF5_AutoFishing.dll'

git tag "v$VERSION"
git push origin "v$VERSION"
 
gh release create "v$VERSION" "$ZIP_NAME" \
  --title "v$VERSION" \
  --generate-notes
 