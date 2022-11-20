using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Common;
namespace Data.Base
{
    public class BaseModel<TId> : IBaseEntity<TId>, IAuditable
    {
        public BaseModel()
        {
            DateCreated = DateTime.Now;
        }
        public TId Id { get; set; }
        [Column(TypeName = DbDataType.DateTime)]
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = DbDataType.DateTime)]
        public DateTime? LastUpdated { get; set; }
        public int? UpdatedBy { get; set; }
    }
    internal interface IBaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
    public interface IAuditable
    {
        public int CreatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? UpdatedBy { get; set; }
    }
    public class DbDataType
    {
        public const string DateTime = "datetime";
        public const string Date = "date";
        public const string Xml = "xml";
    }
}
