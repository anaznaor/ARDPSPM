namespace Span.Culturio.Api.Models
{
    public class PackageDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PackageCultureObject> CultureObjects { get; set; }
        public int ValidDays { get; set; }
    }
}
