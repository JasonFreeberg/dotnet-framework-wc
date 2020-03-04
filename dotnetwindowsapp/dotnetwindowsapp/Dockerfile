#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat 

FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019
ARG source
WORKDIR /inetpub/wwwroot


# COPY copies files or directories from a source host filesystem to a destination

#COPY ${source:-obj/Release} .
# COPY ${source:-bin/Release/PublishOutput} .
#COPY ${source:-.} . == COPY . . == COPY ${source:-ob/Release}
COPY . .

# The following command doesn't work with Azure, but it works with Github Actions. . .How do I figure out what is getting copied over here?
# COPY . .
