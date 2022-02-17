using System.Collections;

public class PersonModel : IEnumerable
{
    public string Name { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Age { get; set; }

    public IEnumerator GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}