namespace Medium.iFX.Utilities
{
    public static class ErrorsExtensions
    {
        public static string ToString(this IEnumerable<Error> errors)
        {
            return string.Join(", ", errors);
        }
    }
}