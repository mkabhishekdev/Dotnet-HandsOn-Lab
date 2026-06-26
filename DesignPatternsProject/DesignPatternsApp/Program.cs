
using DesignPatternsApp.src.DesignPatterns.Behavioral.StatePattern;

var doc = new Document();
doc.State = DocumentStates.Moderation;
doc.Role = UserRoles.Editor;

Console.WriteLine($"Current State: {doc.State}, Current Role: {doc.Role}");

doc.Publish();

Console.WriteLine($"Current State: {doc.State}, Current Role: {doc.Role}");

