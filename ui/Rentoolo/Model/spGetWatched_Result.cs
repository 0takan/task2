//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    
    public partial class spGetWatched_Result
    {
        public long Id { get; set; }
        public long AdvertId { get; set; }
        public System.DateTime CreatedFavorites { get; set; }
        public Nullable<int> Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedAdverts { get; set; }
        public Nullable<System.Guid> CreatedUserId { get; set; }
        public Nullable<double> Price { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Nullable<int> MessageType { get; set; }
        public string ImgUrls { get; set; }
        public string PositionString { get; set; }
    }
}
