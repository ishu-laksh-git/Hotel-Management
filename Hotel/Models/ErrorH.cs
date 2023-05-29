namespace Hotel.Models
{
    public class ErrorH
    {
        public int ID { get; set; }
        public string Message { get; set; }

        public ErrorH(int ID, string Message)
        {
            this.ID = ID;
            this.Message = Message;
        }
    }
}
