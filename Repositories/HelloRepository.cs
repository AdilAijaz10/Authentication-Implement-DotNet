namespace Authentication_Implement_DotNet.Repositories
{
    public class HelloRepository: IHelloRepository
    {
        public string GetMessage()
        {
            return "Hello World";
        }
    }
}
