FROM mcr.microsoft.com/dotnet/core/sdk
RUN echo "Hello World - Dockerfile"
RUN dotnet build
