﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    public List<Product> Products
    {
        get { return this.products; }
        private set { this.products = value; }
    }

    public Person()
    {
        this.Products = new List<Product>();
    }

    public Person(string name, decimal money) : this()
    {
        this.Name = name;
        this.Money = money;
    }

    public void BuyProduct(Product product)
    {
        if (this.Money < product.Cost)
        {
            throw new ArgumentException($"{this.Name} can't afford {product.Name}");
        }
        this.Products.Add(new Product(product.Name, product.Cost));
        this.Money -= product.Cost;
    }

    public override string ToString()
    {
        if (this.Products.Count == 0)
        {
            return $"{this.Name} - Nothing bought";
        }
        return $"{this.Name} - {string.Join(", ", this.Products.Select(p => p.Name))}";
    }
}