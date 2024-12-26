using System;

namespace FortyFlavors.Core.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Role { get; private set; }

    public User(string name, string email, string role)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("İsim boş bırakılamaz!");
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            throw new ArgumentException("Geçersiz e-mail!");
        if (string.IsNullOrWhiteSpace(role))
            throw new ArgumentException("Rol boş bırakılamaz!");

        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Role = role;
    }

    public void UpdateEmail(string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail) || !newEmail.Contains("@"))
            throw new ArgumentException("Geçersiz e-mail.");
        Email = newEmail;
    }

    public void UpdateRole(string newRole)
    {
        if (string.IsNullOrWhiteSpace(newRole))
            throw new ArgumentException("Rol boş bırakılamaz!");
        Role = newRole;
    }
}


