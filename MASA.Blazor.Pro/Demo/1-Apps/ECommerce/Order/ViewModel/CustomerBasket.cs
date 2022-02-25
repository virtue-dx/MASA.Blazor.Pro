﻿namespace MASA.Blazor.Pro.Demo;

public class CustomerBasket
{
    public List<BasketItem> Items { get; set; } = new List<BasketItem>();
}

public class BasketItem
{
    public BasketItem(int id, string name, string company, float score, int qty, string delivery,
        string offers, decimal price, string pictureFileName, bool freeShipping)
    {
        Id = id;
        Name = name;
        Company = company;
        Score = score;
        Qty = qty;
        Delivery = delivery;
        Offers = offers;
        Price = price;
        PictureFileName = pictureFileName;
        FreeShipping = freeShipping;
    }

    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public string Company { get; set; } = default!;

    public float Score { get; set; }

    public int Qty { get; set; }

    public string Delivery { get; set; } = default!;

    public string Offers { get; set; } = "";

    public decimal Price { get; set; }

    public string PictureFileName { get; set; } = "";

    public bool FreeShipping { get; set; }

    public string GetFormatPrice()
    {
        return $"${Price}";
    }

    public string GetPictureUrl()
    {
        return $"./img/apps-eCommerce/{PictureFileName}";
    }
}


