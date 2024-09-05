public class Empolyee
{
    public int Id { get; set; }

    public string Lname { get; set; }

    public string Fname {  get; set; }

    public string Title { get; set; }

    public decimal Salary { get; set; }

    public DateTime Birth_Date { get; set; }

    public override string ToString()
    {
        return $"{Id}: {Lname} {Fname} is living {Title}, is getting salary {Salary}, and is bored in {Birth_Date}";
    }

}
