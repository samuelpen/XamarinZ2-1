﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    public class Response
    {
        public bool IsSuccess { get; set; } //satisfactorio
        public string Message { get; set; }
        public object Result { get; set; }
    }

}
