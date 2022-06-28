namespace PatternCommandLib
{
	public class SimpleRemoteControl
	{
		ICommand command;

		public ICommand Command { set { command = value; } }

		public string ButtonWasPressed()
		{
			return command.Execute();
		}
	}
}
