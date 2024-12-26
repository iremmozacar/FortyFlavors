using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Business
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Address { get; private set; }
    public string PhoneNumber { get; private set; }
    public Guid OwnerId { get; private set; }

    public Business(string name, string address, string phoneNumber, Guid ownerId)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("İsim boş bırakılamaz!");
        if (string.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Adres boş bırakılamaz!");
        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new ArgumentException("Telefon boş bırakılamaz!");

        Id = Guid.NewGuid();
        Name = name;
        Address = address;
        PhoneNumber = phoneNumber;
        OwnerId = ownerId;
    }

    public void UpdateAddress(string newAddress)
    {
        if (string.IsNullOrWhiteSpace(newAddress))
            throw new ArgumentException("Adres boş bırakılamaz!");
        Address = newAddress;
    }

    public void UpdatePhoneNumber(string newPhoneNumber)
    {
        if (string.IsNullOrWhiteSpace(newPhoneNumber))
            throw new ArgumentException("Numara boş bırakılamaz!");
        PhoneNumber = newPhoneNumber;
    }
}
