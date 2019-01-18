
# Azure Functions v2 .NET Core DEMO

## 03-docker - vaseks-host
This demo contains same Function as in ```03-docker/original``` example, but shows how to use my custom Docker image for hosting Azure Functions into Docker container.


### Dockfile structure
As first thing Docker downloads .NET Core SDK image, to compile your function app to ``.dll``.

After that Docker use my modified image for hosting Azure Functions in container.


### How to launch demo

1. fill your Azure storage connection string into Dockerfile in var ```AzureWebJobsStorage``` - this is still required for Azure Functions metadata (Timer, locks,...) and rename ```local.settings.json.template``` to ```local.settings.json```

2. build container

```bash
$ docker build . -t dotnettalks-hello-vaseks-host
```

3. run container on port 8001 (or another if you need)

```bash
$ docker run -d -p "8001:80" --name dotnettalks-hello-vaseks-host dotnettalks-hello-vaseks-host
```

4. open browser on http://localhost:8001/ - you should see Azure Functions page "Your Functions 2.0 app is up and running"

5. on http://localhost:8001/api/hello/ is available Function ```HelloFunction```


### Logs

If you perform command ``$ docker logs dotnettalks-hello-vaseks-host`` , 
you will recieve full output from your app.
