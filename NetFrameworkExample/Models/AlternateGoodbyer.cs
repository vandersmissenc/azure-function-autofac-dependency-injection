﻿namespace AutofacDIExample.Models
{
    public class AlternateGoodbyer : IGoodbyer
    {
        public string Goodbye()
        {
            return "Farewell!";
        }
    }
}
