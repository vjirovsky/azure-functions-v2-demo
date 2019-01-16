docker build . -t dotnettalks-hello
docker run -d -p "8000:80" dotnettalks-hello