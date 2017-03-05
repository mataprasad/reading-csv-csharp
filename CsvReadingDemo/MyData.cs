﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReadingDemo
{
    public class MyData
    {
        public string policyID { get; set; }
        public string statecode { get; set; }
        public string county { get; set; }
        public string eq_site_limit { get; set; }
        public string hu_site_limit { get; set; }
        public string fl_site_limit { get; set; }
        public string fr_site_limit { get; set; }
        public string tiv_2011 { get; set; }
        public string tiv_2012 { get; set; }
        public string eq_site_deductible { get; set; }
        public string hu_site_deductible { get; set; }
        public string fl_site_deductible { get; set; }
        public string fr_site_deductible { get; set; }
        public string point_latitude { get; set; }
        public string point_longitude { get; set; }
        public string line { get; set; }
        public string construction { get; set; }
        public string point_granularity { get; set; }
    }
}
