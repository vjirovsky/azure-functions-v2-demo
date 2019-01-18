# Azure Functions v2 .NET Core DEMO

## 02-bindings-demo - trigger-demo
This example is about how to use ServiceBus trigger - when is added new item into queue by ```output-demo```, Function ```ServiceBusTriggerFunction``` is triggered with item from queue as argument.

Everything important happens in Function argument definition: 
```csharp
[ServiceBusTrigger("items-to-process", Connection = "dotnettalks-servicebus-playground_SERVICEBUS")]string myQueueItem,
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


