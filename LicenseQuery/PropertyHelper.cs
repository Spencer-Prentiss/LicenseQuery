namespace Helpers
{
	public static class PropertyHelper
	{
		public static object GetProperty(object objectToCheck, string propertyName)
		{
			var type = objectToCheck.GetType();
			return type.GetProperty(propertyName).GetValue(objectToCheck);
		}

		public static object SetProperty(object objectToChange, string propertyName, string newValue)
		{
			var type = objectToChange.GetType();
			type.GetProperty(propertyName).SetValue(objectToChange, newValue);
			return type.GetProperty(propertyName).GetValue(objectToChange);
		}
	}
}
