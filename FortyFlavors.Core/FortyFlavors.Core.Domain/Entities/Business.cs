using System;
using System.Collections.Generic;

namespace FortyFlavors.Core.Domain.Entities
{
    public class Business
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }
        public Guid OwnerId { get; private set; }
        public string Email { get; private set; }
        public Guid? CategoryId { get; private set; }
        public Category? Category { get; set; }

        public ICollection<Product>? Products { get; set; }
        public ICollection<Campaign>? Campaigns { get; set; }
        public ICollection<BusinessBankAccount>? BusinessBankAccounts { get; set; } // Navigasyon Özelliği

        public Business(string name, string address, string phoneNumber, Guid ownerId, string email, Guid? categoryId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("İsim boş bırakılamaz!");
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Adres boş bırakılamaz!");
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Telefon boş bırakılamaz!");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email boş bırakılamaz!");

            Id = Guid.NewGuid();
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            OwnerId = ownerId;
            Email = email;
            CategoryId = categoryId;
        }
    }
}