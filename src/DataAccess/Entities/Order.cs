﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    [Table(name: "Order")]
    public class Order
    {
        [Column(name: "Id")]
        public int Id { get; set; }
        [Column(name: "UserId")]
        public string UserId { get; set; }
        [Column(name: "Date")]
        public DateTime Date { get; set; }
    }
}