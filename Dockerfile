# How do you build: $docker build -t testapp .   
# How do you run:   $docker run --rm -v D:\dev\dkr\jacapp\jacapp\bin\Debug:c:\myapp\ testapp

FROM mcr.microsoft.com/dotnet/framework/runtime:4.8 AS runtime
#COPY jacapp/bin/Debug c:/myapp
WORKDIR c:/myapp
ENTRYPOINT ["jacapp.exe"]