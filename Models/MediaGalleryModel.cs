﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mahamesh.Models
{
    public class MediaGalleryModel
    {
        [Key]
        public int MediaId { get; set; }
        public string MediaType { get; set; }
        public string MediaName { get; set; }
        public string MediaLocation { get; set; }
        public string Caption { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}