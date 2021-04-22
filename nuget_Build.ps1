# => https://docs.microsoft.com/ko-kr/nuget/quickstart/create-and-publish-a-package-using-visual-studio-net-framework
# => nuget pack MyProject.csproj -properties Configuration=Release

Remove-Item *.nupkg
.\nuget.exe pack .\CSharpJs\CSharpJs.csproj -properties Configuration=Release
