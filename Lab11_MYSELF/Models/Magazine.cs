namespace Lab11_MYSELF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Magazine
    {
        public Magazine()
        {
            this.WeaponMagazine = new HashSet<WeaponMagazine>();
        }
    
        public int IdMagazine { get; set; }
        public string Country { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<WeaponMagazine> WeaponMagazine { get; set; }
    }
}
