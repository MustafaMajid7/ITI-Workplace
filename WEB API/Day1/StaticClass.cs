using Day1.Models;

namespace Day1
{
	public static class StaticClass
	{
		public static void SetValue<T>(T entity, string propertyName, object value)
		{
			var propertyInfo = entity.GetType().GetProperty(propertyName);

			if (propertyInfo is null) return;

			var type = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;

			var safeValue = (value == null) ? null : Convert.ChangeType(value, type);
			propertyInfo.SetValue(entity, safeValue, null);
		}
	}
}
