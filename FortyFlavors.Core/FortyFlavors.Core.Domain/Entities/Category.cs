using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Category
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public ICollection<Product> Products { get; set; }

    public Category(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Kategori adı boş olamaz.");

        Id = Id;
        Name = name;
        Description = description;
    }

    public void UpdateName(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new ArgumentException("Yeni kategori adı boş olamaz.");
        Name = newName;
    }

    public void UpdateDescription(string newDescription)
    {
        Description = newDescription;
    }
}
