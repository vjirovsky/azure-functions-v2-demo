# Azure Functions v2 .NET Core DEMO

## 02-bindings-demo - output-demo

This example is about how to use output bindings - Function ```ServiceBusOutputBindingFunction``` listens on HTTP request and as result writes to ServiceBus queue.

Everything important happens in Function argument definition: 
```csharp
[ServiceBus("items-to-process",
             Connection = "dotnettalks-servicebus-playground_SERVICEBUS", 
             EntityType = EntityType.Queue)] 
             ICollector<string> outputSbQueue,
```

First parameter with value ```items-to-process``` defines queue name in ServiceBus.

```Connection``` parameter represents connection string to ServiceBus. <br>

<b>Important - this parameter is not directly value with connection string, but it is key for JSON in ```local.settings.json```. So you have to create corresponding value in ```local.settings.json```:
```json
{
    ...

    "dotnettalks-servicebus-playground_SERVICEBUS": "----YOUR-CONNECTION-STRING----",

    ...
}
```
</b>


There is example in ```local.settings.json.template``` file.


