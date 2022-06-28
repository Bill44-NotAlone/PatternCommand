using System;
using PatternCommandLib;

namespace PatternCommand
{
	public class Program
	{
		static void Main(string[] args)
		{
			SimpleRemoteControl simpleRemoteControl = new SimpleRemoteControl();
			LightOnCommand lightOnCommand = new LightOnCommand(new Light());
			GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(new GarageDoor());
			simpleRemoteControl.Command = lightOnCommand;
			Console.WriteLine(simpleRemoteControl.ButtonWasPressed());
			simpleRemoteControl.Command = garageDoorOpenCommand;
			Console.WriteLine(simpleRemoteControl.ButtonWasPressed());
			Console.ReadKey();
		}
	}
}
