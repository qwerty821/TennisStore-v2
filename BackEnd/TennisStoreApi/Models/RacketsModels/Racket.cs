using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace OnlineStore.Models.RacketsModels;

public partial class Racket
{
    public Guid RId { get; set; }

    public string RName { get; set; } = null!;

    public Guid? RBrand { get; set; }

    public decimal RPrice { get; set; }

    public string RImageUrl { get; set; } = null!;

    [JsonIgnore]
    public virtual Brand? RBrandNavigation { get; set; }

    [NotMapped]
    [JsonIgnore]
    public List<Image> images { get; set; }
}
