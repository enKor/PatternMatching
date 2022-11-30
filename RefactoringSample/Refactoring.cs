namespace RefactoringSample;

class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public override string ToString() => $"{LastName}, {FirstName[0]}.";
}

class Student : Person
{
    public int ID { get; init; }
    public override string ToString() => $"{FirstName} {LastName} ({ID}).";
}

//class Teacher : Person
//{
//    public int ID { get; init; }
//    public override string ToString() => $"{FirstName} {LastName} ({ID}).";
//}

internal static class Refactoring
{
    internal static string RenderTask(Person p)
    {
        // 1) What's the content of this method, if we couldn't call ToString() methods of Person or Student types?
        // Have Person/Student ToString() methods contents as business needed to replicate to our new method.

        // 2) For type Person, if FirstName is empty (""), return only LastName.

        throw new NotImplementedException();
    }

    internal static string RenderSolution1(Person p)
    {
        if (p is Student)
        {
            var s = (Student)p;
            return $"{s.FirstName} {s.LastName} ({s.ID}).";
        }

        return p.FirstName == string.Empty
            ? p.LastName
            : $"{p.LastName}, {p.FirstName[0]}.";
    }

    internal static string RenderSolution2(Person p) =>
        p switch
        {
            Student s => $"{s.FirstName} {s.LastName} ({s.ID}).",
            { FirstName: "" } => p.LastName,
            _ => $"{p.LastName}, {p.FirstName[0]}."
        };
}