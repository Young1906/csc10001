using System;

public struct Cate
{
    public string Id;
    public string Name;
    public string Description;

    public static string[] getAttribute()
    {
        return new string[] { "Id", "Name", "Description" };
    }

    public string[] getValue() {
        return new string[] {
            this.Id,
            this.Name,
            this.Description
        };
    }
}

public struct Prod
{
    public string Id;
    public string Name;
    public string Category;
    public string Company;
    public DateTime Expiration;
    public int Year;

    public static string[] getAttribute()
    {
        return new string[] { "Id", "Name", "Category", "Company", "Expiration", "Year" };
    }

    public string[] getValue() {
        return new string[] {
            this.Id,
            this.Name,
            this.Category,
            this.Company,
            this.Expiration.Date.ToString(),
            this.Year.ToString()
        };
    }

}

public struct Query {
    public string key;
    public string query;

    public override string ToString()
    {
        return $"key: {this.key}, query: {this.query} ";
    }
}