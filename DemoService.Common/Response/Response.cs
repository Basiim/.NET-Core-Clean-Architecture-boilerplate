namespace DemoService.Common.Response
{
    public class Response<T>
    {
        public bool Successful { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
