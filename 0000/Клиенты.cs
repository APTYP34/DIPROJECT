//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DIPROJECT._0000
{
    using System;
    using System.Collections.Generic;
    
    public partial class Клиенты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Клиенты()
        {
            this.Заказы = new HashSet<Заказы>();
            this.Заказы1 = new HashSet<Заказы>();
            this.Заказы2 = new HashSet<Заказы>();
            this.Историязаказов = new HashSet<Историязаказов>();
            this.Историязаказов1 = new HashSet<Историязаказов>();
            this.Историязаказов2 = new HashSet<Историязаказов>();
        }
    
        public int IDклиента1 { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public string Отчество { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказы> Заказы { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказы> Заказы1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказы> Заказы2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Историязаказов> Историязаказов { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Историязаказов> Историязаказов1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Историязаказов> Историязаказов2 { get; set; }
    }
}
