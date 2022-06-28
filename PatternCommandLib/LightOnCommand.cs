namespace PatternCommandLib
{
	public class LightOnCommand : ICommand
	{
		Light light;

		public LightOnCommand(Light light)
		{
			this.light = light;
		}
		public string Execute()
		{
			return light.On();
		}
	}
}
