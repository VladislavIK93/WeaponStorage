namespace Lab11_MYSELF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WeaponMagazine
    {
        public int IdWeaponMagazine { get; set; }
        public int IdWeapon { get; set; }
        public int IdMagazine { get; set; }
    
        public virtual Magazine Magazine { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}
