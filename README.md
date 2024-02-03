# StringConcatenation

Showcases some of the methods available for string concatenation.

In software development, there's usually a hundred different ways to code the same thing; String concatenation is no exception. Here we have 6 examples of how we can combine strings, by: using the '+' operator, string.Concat, string.Join, string interpolation, string.Format, and StringBuilder. Note that there are other options that have not been mentioned...

Here are some interesting observations with the code in the attached image:

1) Using the '+' operator and string.Concat produce the exact same IL code. As such, they should perform identical and use the same memory allocation. The difference we're seeing in performance is most likely an anomaly, I can't explain it.

2) string.Join shouldn't be used to concatenate strings like this and the poor performance is only one reason why. Use this only if you have to add a proper delimiter.

3) String interop ($"") uses DefaultInterpolatedStringHandler behind the scenes. We get lower memory allocation due to it's use of the Span structure.

4) string.Format was added to illustrate something interesting; It's slow. If you need to format a hardcoded string, use string interpolation with $ instead.

5) Last, it's no surprise, StringBuilder is the winner here. It's super fast and it strikes a balance with memory allocation.

It's always interesting to explore how our code really works. By looking at what happens behind the scenes, we get a better understanding of how our code will perform.
