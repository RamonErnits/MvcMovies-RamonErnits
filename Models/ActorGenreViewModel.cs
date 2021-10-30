﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMoviesR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMoviesR.Models
{
    public class ActorGenreViewModel
    {
        public List<Actor> Actors { get; set; }
        public SelectList Age { get; set; }
        public string actorSalary { get; set; }
        public string searchString { get; set; }
    }
}
