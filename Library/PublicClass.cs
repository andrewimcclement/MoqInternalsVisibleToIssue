namespace Library;

public class PublicClass
{
    internal virtual string Foo()
    {
        return "Foo";
    }

    protected string GetFoo() => Foo();
}