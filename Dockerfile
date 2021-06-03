FROM mcr.microsoft.com/dotnet/sdk:5.0	

WORKDIR /bin/Debug/net5.0/

EXPOSE 80

COPY /bin/Debug/net5.0/ .

CMD [ "dotnet", "build" ]

ENTRYPOINT [ "dotnet", "test.dll" ]