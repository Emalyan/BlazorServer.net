using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.WebEncoders.Testing;

namespace BlazorServerApp.Components.Card.Model
{
    public class CardModel
    {    
        public CardModel(int order)
        {
            var random = new Random();
            Id = random.Next().ToString();
            Order = order;
        }
        public string Id { get; }
        public string Value { get; set; } 
        
        public int Order { get; set; }

        public void SetValue(ChangeEventArgs value)
        {            
            Value = value.Value.ToString();
        }

        public void RemoveCard(List<CardModel> cards)
        {
            var card = cards.FirstOrDefault(x => x.Id == Id);
            cards.Remove(card);
        }

        public void DragEnd(DragEventArgs args)
        {
            var test = args;
        }
    }
}
