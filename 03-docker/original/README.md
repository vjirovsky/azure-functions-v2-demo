# Azure Functions v2 .NET Core DEMO

## 03-docker - original
This demo shows how to use Microsoft's Docker image for hosting Azure Functions into Docker container.


### Dockfile structure
As first thing Docker downloads .NET Core SDK image, to compile your function app to ``.dll``.

After that Docker use Microsoft's official image for hosting Azure Functions in container.


### How to launch demo

1. fill your Azure storage connection string into Dockerfile in var ```AzureWebJobsStorage``` and rename ```local.settings.json.template``` to ```local.settings.json```

2. build container

```bash
$ docker build . -t dotnettalks-hello
```

3. run container on port 8000 (or another if you need)

```bash
$ docker run -d -p "8000:80" --name dotnettalks-hello dotnettalks-hello
```

4. open browser on http://localhost:8000/ - you should see Azure Functions page "Your Functions 2.0 app is up and running"

5. on http://localhost:8000/api/hello/ is available Function ```HelloFunction```


### Logs

If you perform command ``$ docker logs dotnettalks-hello``, 
there is no more output than:

```
Hosting environment: Production
Content root path: /
Now listening on: http://[::]:80
Application started. Press Ctrl+C to shut down.
```
It's because logs from app are redirected to blob storage in Azure Storage, you provided in Step 1.