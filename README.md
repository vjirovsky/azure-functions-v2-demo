# Azure Functions v2 .NET Core DEMO

## 01-basic-usage

This example shows, how is easy to create Function ```CreateNewOrderFunction```, listening on HTTP GET,POST request on address ```/api/create-order/``` 

## 02-bindings-demo - output-demo

This example is about how to use output bindings - Function ```ServiceBusOutputBindingFunction``` listens on HTTP request and as result writes to ServiceBus queue.

## 02-bindings-demo - trigger-demo

This example is about how to use ServiceBus trigger - when is added new item into queue by ```output-demo```, Function ```ServiceBusTriggerFunction``` is triggered with item from queue as argument.


## 03-docker - original
This demo shows how to use Microsoft's Docker image for hosting Azure Functions into Docker container.

## 03-docker - vaseks-host
This demo is about how to use my custom Docker image for hosting Azure Functions into Docker container.