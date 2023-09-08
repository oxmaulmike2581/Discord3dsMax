
namespace Discord3dsMax
{
	public class Main
	{
		public static void AssemblyMain()
		{
			Discord.Initialize();
		}

		public static void AssemblyShutdown()
		{
			Discord.Dispose();
		}
	}
}
