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
    
    public partial class Заказы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заказы()
        {
            this.Историязаказов = new HashSet<Историязаказов>();
            this.Историязаказов1 = new HashSet<Историязаказов>();
            this.Историязаказов2 = new HashSet<Историязаказов>();
            this.Историязаказов3 = new HashSet<Историязаказов>();
            this.Историязаказов4 = new HashSet<Историязаказов>();
        }
    
        public int IDзаказа1 { get; set; }
        public Nullable<int> Фамилия2 { get; set; }
        public Nullable<int> Имя2 { get; set; }
        public Nullable<int> Отчество2 { get; set; }
        public Nullable<int> Поставщик2 { get; set; }
        public Nullable<int> Банк2 { get; set; }
        public Nullable<int> Сумма { get; set; }
        public Nullable<System.DateTime> Дата { get; set; }
    
        public virtual Клиенты Клиенты { get; set; }
        public virtual Клиенты Клиенты1 { get; set; }
        public virtual Клиенты Клиенты2 { get; set; }
        public virtual Платежи Платежи { get; set; }
        public virtual Поставщики Поставщики { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Историязаказов> Историязаказов { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Историязаказов> Историязаказов1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Историязаказов> Историязаказов2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Историязаказов> Историязаказов3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Историязаказов> Историязаказов4 { get; set; }
    }
}
