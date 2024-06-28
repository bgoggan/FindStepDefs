using Reqnroll;

namespace StepDefs
{
    [Binding]
    public sealed class StepDefinitions
    {
        [StepDefinition(@"This is a test step definition")]
        public void CanYouFindMe()
        {
            Console.WriteLine("This is a test step definition");
        }
    }
}