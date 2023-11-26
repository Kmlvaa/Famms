using System;
using Famms.Entities;
namespace Famms.Data
{
    public class ProductList
    {
        public static List<Product> Products()
        {
            return new()
            {
                new()
                {
                    Name = "Men's Shirt",
                    ImgUrl = "images/p1.png",
                    Price = "$75"
                },
                new()
                {
                    Name = "Men's Shirt",
                    ImgUrl = "images/p2.png",
                    Price = "$80"
                },
                new()
                {
                    Name = "Women's dress",
                    ImgUrl = "images/p3.png",
                    Price = "$78"
                },
                new()
                {
                    Name = "Women's dress",
                    ImgUrl = "images/p4.png",
                    Price = "$93"
                },
                new()
                {
                    Name = "Women's dress",
                    ImgUrl = "images/p5.png",
                    Price = "$65"
                },
                new()
                {
                    Name = "Women's dress",
                    ImgUrl = "images/p6.png",
                    Price = "$81"
                },
                new()
                {
                    Name = "Men's Shirt",
                    ImgUrl = "images/p7.png",
                    Price = "$99"
                },
                new()
                {
                    Name = "Women's dress",
                    ImgUrl = "images/p8.png",
                    Price = "$75"
                },
                new()
                {
                    Name = "Men's Shirt",
                    ImgUrl = "images/p9.png",
                    Price = "$75"
                },
                new()
                {
                    Name = "Men's Shirt",
                    ImgUrl = "images/p10.png",
                    Price = "$75"
                },
                new()
                {
                    Name = "Men's Shirt",
                    ImgUrl = "images/p11.png",
                    Price = "$75"
                },
                new()
                {
                    Name = "Men's Shirt",
                    ImgUrl = "images/p12.png",
                    Price = "$75"
                },
            };
        }
    }
}
