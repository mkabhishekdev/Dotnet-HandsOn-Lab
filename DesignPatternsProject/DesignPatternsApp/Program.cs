
using DesignPatternsApp.src.DesignPatterns.Behavioral.ChainOfResponsibilityPattern;

WebServer webServer = new WebServer();
HttpRequest request = new HttpRequest("admin", "password");
webServer.HandleRequest(request);
