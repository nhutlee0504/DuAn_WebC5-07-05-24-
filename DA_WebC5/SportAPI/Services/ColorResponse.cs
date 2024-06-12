using Microsoft.EntityFrameworkCore;
using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace SportAPI.Services
{
    public class ColorResponse : IColor
    {
        private readonly ApplicationDbContext context;
        private readonly List<Colors> _colors;
        public ColorResponse(ApplicationDbContext ct) => context = ct;

        public Colors AddColor(Colors colors)
        {
            try
            {
                context.Colors.Add(colors);
                context.SaveChanges();
                return colors;
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        public Colors GetColorById(int id)
        {
            return context.Colors.FirstOrDefault(c => c.IDColor == id);
        }

        public IEnumerable<Colors> GetColors()
        {
           return context.Colors;
        }

        public Colors UpdateColor(int id,Colors updatedColor)
        {
            var existingColor = GetColorById(updatedColor.IDColor);

            if (existingColor != null)
            {
                existingColor.Color = updatedColor.Color;
                context.SaveChanges();
            }

            return existingColor;
        }
    }
}
