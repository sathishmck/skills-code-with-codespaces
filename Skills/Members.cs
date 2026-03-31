internal static class Members
{
    internal static string GetMemberInfo(string name)
    {
        if (name == "Alice")
        {
            return "Name: Alice, Age: 30, Role: Developer";
        }

        if (name == "Bob")
        {
            return "Name: Bob, Age: 25, Role: Designer";
        }

        return "Member not found.";
    }
}