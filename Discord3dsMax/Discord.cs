using DiscordRPC;

namespace Discord3dsMax
{
	public static class Discord
	{
		public static DiscordRpcClient client;
		public static RichPresence presence;

		public static void Initialize()
		{
			// enter Application ID here
			// it's not safe to store id here but I'm too lazy to move it to the config file

			client = new DiscordRpcClient(AppIDs.MAX_2024.ToString());
			presence = new RichPresence()
			{
				Assets = new Assets()
				{
					LargeImageKey = "image_large"
				},
				Timestamps = Timestamps.Now
			};

			client.OnReady += (sender, e) => {};
			client.OnPresenceUpdate += (sender, e) => {};
			client.Initialize();
			client.SetPresence(presence);
		}

		/// <summary>
		/// Sets the current opened scene name in presence details
		/// </summary>
		/// <param name="sceneName">scene name</param>
		public static void SetSceneName(string sceneName)
		{
			presence.Details = sceneName;
			Update();
		}

		public static void Dispose()
		{
			client.Dispose();
		}

		public static void Update()
		{
			client.OnPresenceUpdate += (sender, e) => {};
			client.ClearPresence();
			client.SetPresence(presence);
		}

		private enum AppIDs : long
		{
			MAX_2015 = 988215076626509824,
			MAX_2020 = 988080926414209084,
			MAX_2023 = 982293883306270790,
			MAX_2024 = 1149627242478043157
		}
	}
}
