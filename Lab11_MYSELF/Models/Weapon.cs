namespace Lab11_MYSELF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Weapon
    {
        public Weapon()
        {
            this.WeaponMagazine = new HashSet<WeaponMagazine>();
        }
    
        public int IdWeapon { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<WeaponMagazine> WeaponMagazine { get; set; }
    }
}
