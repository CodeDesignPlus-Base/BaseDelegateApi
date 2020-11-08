namespace BaseDelegateApi.Dto
{
    public class CityDto
    {
        public string ObjectId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public string AltName { get; set; }
        public CountryDto Country { get; set; }
        public string AdminCode { get; set; }
        public int Population { get; set; }
        public Location Location { get; set; }
    }
}
