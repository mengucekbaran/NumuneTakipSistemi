//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleManagmentSystem.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NUMUNE_TAKİPEntities : DbContext
    {
        public NUMUNE_TAKİPEntities()
            : base("name=NUMUNE_TAKİPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NUMUNE_HAREKETLERI> NUMUNE_HAREKETLERI { get; set; }
        public virtual DbSet<TblNumuneler> TblNumuneler { get; set; }
    
        public virtual ObjectResult<ListAllNumune_Result> ListAllNumune(Nullable<System.DateTime> ilk_tarih, Nullable<System.DateTime> son_tarih)
        {
            var ilk_tarihParameter = ilk_tarih.HasValue ?
                new ObjectParameter("ilk_tarih", ilk_tarih) :
                new ObjectParameter("ilk_tarih", typeof(System.DateTime));
    
            var son_tarihParameter = son_tarih.HasValue ?
                new ObjectParameter("son_tarih", son_tarih) :
                new ObjectParameter("son_tarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListAllNumune_Result>("ListAllNumune", ilk_tarihParameter, son_tarihParameter);
        }
    
        public virtual ObjectResult<ListNumune_Result> ListNumune(Nullable<int> user_no, Nullable<System.DateTime> ilk_tarih, Nullable<System.DateTime> son_tarih)
        {
            var user_noParameter = user_no.HasValue ?
                new ObjectParameter("user_no", user_no) :
                new ObjectParameter("user_no", typeof(int));
    
            var ilk_tarihParameter = ilk_tarih.HasValue ?
                new ObjectParameter("ilk_tarih", ilk_tarih) :
                new ObjectParameter("ilk_tarih", typeof(System.DateTime));
    
            var son_tarihParameter = son_tarih.HasValue ?
                new ObjectParameter("son_tarih", son_tarih) :
                new ObjectParameter("son_tarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListNumune_Result>("ListNumune", user_noParameter, ilk_tarihParameter, son_tarihParameter);
        }
    }
}
