namespace Courier.Data
{
    public class Parcel
    {
        public int Id { get; set; }
        public float Size { get; set; }

        public Parcel(int id, float size)
        {
            Id = id;
            Size = size;
        }
    }
}
