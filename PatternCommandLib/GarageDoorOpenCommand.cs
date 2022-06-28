namespace PatternCommandLib
{
	public class GarageDoorOpenCommand : ICommand
	{
		GarageDoor garageDoor;

		public GarageDoorOpenCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}

		public string Execute()
		{
			return garageDoor.Open();
		}
	}
}
