﻿class Customer
{
    public string CardNumber { get; set; }
    public string Pin { get; set; }
    public string FullName { get; set; }
    public int Balance { get; set; }

    public Customer(string cardNumber, string pin, string fullName, int balance)
    {
        CardNumber = cardNumber;
        Pin = pin;
        FullName = fullName;
        Balance = balance;
    }
}
