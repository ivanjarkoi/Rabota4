namespace P1
{
    public interface IOrdet1
    {
        OrderItem OrderItem { get; set; }

        void Create();
        void GetInfo();
        void SetInfo();
    }
}