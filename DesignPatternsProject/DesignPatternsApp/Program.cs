
using DesignPatternsApp.src.DesignPatterns.Structural.Adapter;
using DesignPatternsApp.src.DesignPatterns.Structural.Adapter.Package;

var videoEditor = new VideoEditor(new Video());
videoEditor.ApplyColor(new RainbowColor(new Rainbow()));

