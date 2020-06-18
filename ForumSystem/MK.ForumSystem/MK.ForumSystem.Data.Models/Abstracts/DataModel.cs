using MK.ForumSystem.Data.Models.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MK.ForumSystem.Data.Models.Abstracts
{
    public abstract class DataModel : IAuditable, IDeletable
    {
        public DataModel()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }

        [Index]
        public bool IsDeleted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DeletedOn { get; set; }
    }
}
