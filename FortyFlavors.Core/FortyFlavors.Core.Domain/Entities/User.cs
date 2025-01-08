using System;

namespace FortyFlavors.Core.Domain.Entities;

public class User
{
    public User() { }

    public User(string name, string email, string password, string role)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("İsim boş bırakılamaz!");
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            throw new ArgumentException("Geçersiz e-posta!");
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Şifre boş bırakılamaz!");
        if (string.IsNullOrWhiteSpace(role))
            throw new ArgumentException("Rol boş bırakılamaz!");

        Name = name;
        Email = email;
        Password = password;
        Role = role;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Username { get; set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string Role { get; private set; }

    public ICollection<Order>? Orders { get; set; }
    public ICollection<Basket>? Baskets { get; set; }
    public ICollection<Review>? Reviews { get; set; }
    public ICollection<Message>? SentMessages { get; set; }
    public ICollection<Message>? ReceivedMessages { get; set; }
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Likes> Likes { get; set; } = new List<Likes>();

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
    public void SetPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Şifre boş bırakılamaz!");
        Password = password;
    }
}