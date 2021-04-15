using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models.Components
{
    public class ColorsData
    {
        private List<Color> colors = new List<Color> {    // Alle Colors in Color umstellen
 new Color { Name = "Blau", HexCode = "23423"},
 new Color { Name = "Gelb", HexCode = "34343"},
 new Color { Name = "Rot", HexCode = "34342" },
 new Color { Name = "Grün", HexCode = "0X3434"}
 };
        public IEnumerable<Color> Colors => colors;
        public void AddColor(Color newColor)
        {
            colors.Add(newColor);
        }
    }
}
