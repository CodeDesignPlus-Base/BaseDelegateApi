namespace BaseDelegateApi.Entities
{
    public class City
    {
        public string ObjectId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public string AltName { get; set; }
        public Country Country { get; set; }
        public string AdminCode { get; set; }
        public int Population { get; set; }
    }
}
