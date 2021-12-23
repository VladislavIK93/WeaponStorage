using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab_11Audit.Models
{
    [MetadataType(typeof(WeaponMetaData))]
    public partial class Weapon
    {
        [Bind(Exclude = "IdWeapon")]
        public class WeaponMetaData
        {
            [ScaffoldColumn(false)]
            public int IdWeapon { get; set; }

            [DisplayName("Name")]
            [Required(ErrorMessage = "Weapon name is required.")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(20)]
            public string Name { get; set; }

            [DisplayName("Status")]
            [Required(ErrorMessage = "Status is required.")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(20)]
            public string Status { get; set; }
        }
    }
}