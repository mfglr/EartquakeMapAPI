namespace Core.DTOs
{
    public class Response<T> where T : class
    {
        public T data { get; set; }
        
        public Response(T data) {
            this.data = data;
        }
    }
}
