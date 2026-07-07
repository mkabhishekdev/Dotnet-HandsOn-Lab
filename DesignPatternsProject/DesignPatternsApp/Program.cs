
using DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Good;
using RemoteControl = DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Good.RemoteControl;

var lgRemoteControl = new RemoteControl(new LGRadio());
lgRemoteControl.TurnOn();
lgRemoteControl.TurnOff();

var advancedSonyRemoteControl = new AdvancedRemote(new SonyRadio());
advancedSonyRemoteControl.TurnOn();
advancedSonyRemoteControl.TurnOff();

