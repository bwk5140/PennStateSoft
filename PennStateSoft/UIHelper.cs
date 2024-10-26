using Microsoft.AspNetCore.Components;

namespace PennStateSoft
{
    public class UIHelper
    {
        [Parameter]
        public int Rows { get; set; }

        public void CalculateSize(string value)
        {

            Rows = value.Length / 100;
            int rem = value.Length % 100;
            if (rem != 0 && Rows == 1)
            {
                Rows += 1;
            }
        }
    }
}
