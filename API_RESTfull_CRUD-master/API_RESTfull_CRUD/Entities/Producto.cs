﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading. Tasks;



namespace API_RESTfull_CRUD.Entities
{
    public class Producto

    {
        [Key]
        public String pro_codigo { get; set; }
        public String pro_nombre { get; set; }
        public String pro_descripcion { get; set; }
        public decimal pro_precio { get; set; }



    }
}
