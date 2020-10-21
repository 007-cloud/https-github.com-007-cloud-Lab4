using dotNetLab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetLab4
{
    public class SampleData
    {
        public static void Initialize(NoteBookContext context)
        {
            if (!context.NoteBook.Any())
            {
                context.NoteBook.AddRange(
                    new NoteBook
                    {
                        Name = "Macbook",
                        Company = "Apple",
                        Price = 500
                    },
                    new NoteBook
                    {
                        Name = "Nitro",
                        Company = "Acer",
                        Price = 300
                    },
                    new NoteBook
                    {
                        Name = "GTX",
                        Company = "LENOVO",
                        Price = 350
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
