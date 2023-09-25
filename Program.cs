using jsontry;
using Newtonsoft.Json;
using System.Xml.Serialization;

//User user = new User()
//{
//    Id = 2,
//    Name = "Gus",
//    UserName = "Antonelle",
//    Email = "email@gmail.com",
//    Adress = new Adress() 
//    {
//        Street = "Victor Plains",
//        City = "Tokio", ZipCode = "90566-7771", 
//        geo = new Geo()
//        {
//            Lat = "-47.2345",
//            Lng = "-34.1324"
//        } 
//    },
//    Phone = "+998 88 888 88 85",
//    Website = "https://poe.com/chat/2kfs7ineznqi2oiezyu",
//    Company = new Company()
//    {
//        Name = "Apple", CatchPhrase = "Productivity", Bs = "Lol something"
//    }
//};
//string json = JsonConvert.SerializeObject(user, Formatting.Indented);


var person = new Person()
{
    Name = "Jason",
    Age = 31,
    City = "Sweden",
    Place = new Place() { Home = "Flat"}
};


var serializer = new XmlSerializer(typeof(Person));
using (TextWriter writer = new StringWriter())
{
    serializer.Serialize(writer, person);
    string xml = writer.ToString();

    Console.WriteLine("XML: " + xml);
}









