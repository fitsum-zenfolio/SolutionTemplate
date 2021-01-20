namespace DPL.Template.Accessors
{
    public class TestAccessor : ITestAccessor
    {
        public string TestMe(string input)
        {
            return input + " hello";
        }
    }
}
