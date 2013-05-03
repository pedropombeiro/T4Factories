namespace T4Factories
{
	public interface IDateTimeFactory
	{
        System.DateTime Create(System.Int64 ticks);
        System.DateTime Create(System.Int64 ticks, System.DateTimeKind kind);
        System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day);
        System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Globalization.Calendar calendar);
        System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second);
        System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.DateTimeKind kind);
        System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.Globalization.Calendar calendar);
        System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.Int32 millisecond);
        System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.Int32 millisecond, System.DateTimeKind kind);
        System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.Int32 millisecond, System.Globalization.Calendar calendar);
        System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.Int32 millisecond, System.Globalization.Calendar calendar, System.DateTimeKind kind);
    }

    public class DateTimeFactory : IDateTimeFactory
    {
		public System.DateTime Create(System.Int64 ticks)
		{
			return new System.DateTime(ticks);
		}

		public System.DateTime Create(System.Int64 ticks, System.DateTimeKind kind)
		{
			return new System.DateTime(ticks, kind);
		}

		public System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day)
		{
			return new System.DateTime(year, month, day);
		}

		public System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Globalization.Calendar calendar)
		{
			return new System.DateTime(year, month, day, calendar);
		}

		public System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second)
		{
			return new System.DateTime(year, month, day, hour, minute, second);
		}

		public System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.DateTimeKind kind)
		{
			return new System.DateTime(year, month, day, hour, minute, second, kind);
		}

		public System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.Globalization.Calendar calendar)
		{
			return new System.DateTime(year, month, day, hour, minute, second, calendar);
		}

		public System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.Int32 millisecond)
		{
			return new System.DateTime(year, month, day, hour, minute, second, millisecond);
		}

		public System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.Int32 millisecond, System.DateTimeKind kind)
		{
			return new System.DateTime(year, month, day, hour, minute, second, millisecond, kind);
		}

		public System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.Int32 millisecond, System.Globalization.Calendar calendar)
		{
			return new System.DateTime(year, month, day, hour, minute, second, millisecond, calendar);
		}

		public System.DateTime Create(System.Int32 year, System.Int32 month, System.Int32 day, System.Int32 hour, System.Int32 minute, System.Int32 second, System.Int32 millisecond, System.Globalization.Calendar calendar, System.DateTimeKind kind)
		{
			return new System.DateTime(year, month, day, hour, minute, second, millisecond, calendar, kind);
		}

	}
}
