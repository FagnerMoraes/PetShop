﻿namespace PetShop.Domain.Entities.Shared;

public abstract class Entity
{
    public int Id { get; protected set; }
    public bool Status { get; protected set; }
}
