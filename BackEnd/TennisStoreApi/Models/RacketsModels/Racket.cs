using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace OnlineStore.Models.RacketsModels;

public partial class Racket
{
    [BindProperty(Name = "id")]
    public Guid Id { get; set; }

    [BindProperty(Name = "name")]
    public string Name { get; set; } = null!;

    [BindProperty(Name = "brand")]
    public Guid? Brand { get; set; }

    [BindProperty(Name = "price")]
    public decimal Price { get; set; }

    [BindProperty(Name = "imageUrl")]
    public string ImageUrl { get; set; } = null!;

    [JsonIgnore]
    public virtual Brand? RBrandNavigation { get; set; }

    [NotMapped]
    [JsonIgnore]
    public List<Image> images { get; set; }
}