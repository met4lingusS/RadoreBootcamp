namespace RegisteringClassLibrary.AttributeClasses
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class RegisteringRequirementsAttribute : Attribute
    {

    }
}
