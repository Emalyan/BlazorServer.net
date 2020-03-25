using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Components.Card
{
    public class CardData
    {        
        public string Id { get; set; }
        public string Value { get; set; }

        public void SetValue(string value)
        {
            Value = value;
        }
    }
}
