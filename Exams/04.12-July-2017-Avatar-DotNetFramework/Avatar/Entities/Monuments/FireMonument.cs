﻿public class FireMonument : Monument
{
    public FireMonument(string name, int affinity) : base(name)
    {
        this.Affinity = affinity;
    }

    public override int Affinity { get; set; }

    public override string ToString()
    {
        return base.ToString() + this.Affinity;
    }
}