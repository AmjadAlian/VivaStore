using Newtonsoft.Json;

namespace Landing.PL.Helpers
{
	public static class SessionSettings
	{
		
	
			public static void SetObjectAsJson(this ISession session, string key, object value)
			{
				session.SetString(key, JsonConvert.SerializeObject(value));
			}

			public static T GetObjectFromJson<T>(this ISession session, string key)
			{
				var value = session.GetString(key);
				return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
			}
		
	}
}
