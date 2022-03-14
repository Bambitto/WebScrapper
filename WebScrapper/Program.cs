using Newtonsoft.Json;
using WebScrapper;

var countryScrapper = new CountryScrapper();

var countries = countryScrapper.GetCountries();

var cityScrapper = new CityScrapper();

var result = new List<CountryDetails>();
foreach(var country in countries)
{
    Console.WriteLine($"Getting cities for: {country.Name}");
    var cities = cityScrapper.GetCities(country);

    result.Add(new CountryDetails()
    {
        Code = country.Code,
        Name = country.Name,
        Cities = cities
    });
}

var json = JsonConvert.SerializeObject(result);

File.WriteAllText(@"C:\files\result.json", json);

Console.WriteLine("finished");