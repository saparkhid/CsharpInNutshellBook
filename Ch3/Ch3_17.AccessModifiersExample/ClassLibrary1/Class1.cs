namespace ClassLibrary1
{
    public class Class1
    {
        Class2 class2;
        public Class1()
        {
            class2 = new Class2();
        }
        protected virtual void Foo()
        {
        }
        protected internal virtual void Bar()
        {

        }
        private protected virtual void FooBar()
        {
            //outside classes can not override this method
            //only internal mebmers
        }
    }
}