﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CarteiraDigital.Models
{
    public class Inflow
    {

        [Display(Name = "Código")]
        public virtual long Id { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public virtual DateTime InflowDate { get; set; }

        [Display(Name = "Descrição")]
        public virtual string InflowDescription { get; set; }

        [Display(Name = "Valor do depósito")]
        [DataType(DataType.Currency)]
        public virtual double InflowAmount { get; set; }

        [Display(Name = "Pessoa")]
        public virtual Person Person { get; set; }

        public virtual Filter Filter { get; set; }

        public Inflow() { }

        public Inflow(long id, DateTime inflowDate, string inflowDescription, double inflowAmount)
        {
            Id = id;
            InflowDate = inflowDate;
            InflowDescription = inflowDescription;
            InflowAmount = inflowAmount;
        }
    }
}
