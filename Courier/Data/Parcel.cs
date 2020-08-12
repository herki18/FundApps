namespace Courier.Data
{
    public class Parcel
    {
        public int Id { get; set; }
        public float Size { get; set; }
        public float Weight { get; set; }

        public Parcel(int id, float size, float weight)
        {
            Id = id;
            Size = size;
            Weight = weight;
        }
    }
}
