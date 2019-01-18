# Azure Functions v2 .NET Core DEMO

## 02-bindings-demo - output-demo

This example is about how to use output bindings - Function ```ServiceBusOutputBindingFunction``` listens on HTTP request and as result writes to ServiceBus queue.

## 02-bindings-demo - trigger-demo

This example is about how to use ServiceBus trigger - when is added new item into queue by ```output-demo```, Function ```ServiceBusTriggerFunction``` is triggered with item from queue as argument.