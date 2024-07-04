using Library;

namespace Production;

internal class InternalDerivedClass : PublicClass
{
    public virtual string Bar() => "Bar" + GetFoo();
}