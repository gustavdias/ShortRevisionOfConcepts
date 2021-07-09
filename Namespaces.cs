namespace MyNamespace
{
    class System { }//this overides the System from dotnet
    class MyClass
    {
        static void Main(string[] args)
        {
            global::System.Console.WriteLine("Hello World!");//global system namespace
            //MyNestedNamespace.MyClass to reference MyClass
        }

    }

    namespace MyNestedNamespace
    {
        class MyClass
        {

        }
    }
}