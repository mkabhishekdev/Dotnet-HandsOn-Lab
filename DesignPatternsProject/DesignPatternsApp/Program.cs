
using DesignPatternsApp.src.DesignPatterns.Behavioral.TemplatePattern.GoodExample;

var beverageMaker = new BeverageMaker(new Tea());
beverageMaker.MakeBeverage();

beverageMaker.SetBeverage(new Chamomile());
beverageMaker.MakeBeverage();
