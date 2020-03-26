using System;
using System.Collections.Generic;
using BlazorServerApp.Components.Card.Model;

namespace BlazorServerApp.Components.Table.Row.Models
{
    public class RowModel
    {
        public RowModel()
        {
            var random = new Random();
            Id = random.Next().ToString();
            Cards = new List<CardModel>();
        }
        public string Id { get; set; }
        public List<CardModel> Cards { get; set; }
    }
}
