internal static class StudendExt
{
    public static string get_FullName(this Student v)
    {
        return $"{v.Surname} {v.Name}";
    }
}
