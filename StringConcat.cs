using System.Text;

namespace StringConcatenationDemo;

public class StringConcatenation
{
    public static string StringPlusString(string s1 = "a", string s2 = "b", string s3 ="c", string s4 ="d")
    {
        return s1 + s2 + s3 + s4 + s1 + s2 + s3 + s4 + s1 + s2 + s3 + s4 + s1 + s2 + s3 + s4;
    }

    public static string StringConcate(string s1 = "a", string s2 = "b", string s3 ="c", string s4 ="d")
    {
        return string.Concat(s1, s2, s3, s4, s1, s2, s3, s4, s1, s2, s3, s4, s1, s2, s3, s4);
    }

    public static string StringJoin(string s1 = "a", string s2 = "b", string s3 ="c", string s4 ="d")
    {
        return string.Join("", s1, s2, s3, s4, s1, s2, s3, s4, s1, s2, s3, s4, s1, s2, s3, s4);
    }

    public static string StringInterop(string s1 = "a", string s2 = "b", string s3 ="c", string s4 ="d")
    {
        return $"{s1}{s2}{s3}{s4}{s1}{s2}{s3}{s4}{s1}{s2}{s3}{s4}{s1}{s2}{s3}{s4}";
    }

    public static string StringFormat(string s1 = "a", string s2 = "b", string s3 ="c", string s4 ="d")
    {
        return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}",
                            s1, s2, s3, s4, s1, s2, s3, s4, s1, s2, s3, s4, s1, s2, s3, s4);
    }

    public static string StringBuilder(string s1 = "a", string s2 = "b", string s3 ="c", string s4 ="d")
    {
        StringBuilder sb = new StringBuilder();
            sb.Append(s1).Append(s2).Append(s3).Append(s4)
                .Append(s1).Append(s2).Append(s3).Append(s4)
                .Append(s1).Append(s2).Append(s3).Append(s4)
                .Append(s1).Append(s2).Append(s3).Append(s4);

        return sb.ToString();
    }
}