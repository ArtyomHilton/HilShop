using System;
using System.Collections.Generic;
using System.Text;

using HilShop.Domain.Exceptions;

namespace HilShop.Domain.Entities.User.ValueObjects;

public class PasswordHash
{
    public string Value { get; private set; }

    public PasswordHash(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new EmailNullException();

        Value = value;
    }
}