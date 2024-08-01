using System;
using System.Collections.Generic;

namespace CarShopWpf.Models;

public partial class Registration
{
    public int IdPerson { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Patronymic { get; set; }

    public string NumberProne { get; set; }

    public string City { get; set; }

    public byte[] Avatar { get; set; }

    public string Password { get; set; }
}
