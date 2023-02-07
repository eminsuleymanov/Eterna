using System;
using Eterna.Models;

namespace Eterna.ViewModels.AboutVM
{
    public class AboutVM
    {
        public List<Statistic> Statistics { get; set; }
        public List<Client> Clients { get; set; }
        public List<Testimonial> Testimonials { get; set; }

    }
}

