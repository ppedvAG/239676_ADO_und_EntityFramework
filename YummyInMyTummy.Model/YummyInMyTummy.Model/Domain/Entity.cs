﻿namespace YummyInMyTummy.Model.Domain;

public abstract class Entity
{
    public int Id { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Modified { get; set; } = DateTime.Now;
}
