namespace PasswordGeneratorConsole
{
    public class ExampleClassForUnitTests
    {
        private string _testParam;

        public ExampleClassForUnitTests(string testParam)
        {
            _testParam = testParam;
        }

        public string GetTestParam()
        {
            return _testParam;
        }

        public void SetTestParam(string testParam)
        {
            this._testParam = testParam;
        }
    }
}
