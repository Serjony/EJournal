﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.BasicModels
{
    public class CommentDTO
    {
        public int? Id { get; set; }
        public string Comment { get; set; }
        public int? IdStudent { get; set; }
        public int? IdTeacher { get; set; }
        public int? IdCommentType { get; set; }
        public bool IsDelete { get; set; }
    }
}
