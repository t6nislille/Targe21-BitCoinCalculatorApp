﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinApp
{
    public class bitCoinRates
    {
        public bpi bpi { get; set; }
    }

    public class bpi
    {
        public EUR EUR { get; set; }
        public USD USD { get; set; }
        public GBP GBP { get; set; }
    }
    public class EUR
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }

    public class USD
    {
        public string code { set; get; }
        public float rate_float { set; get; }
    }

    public class GBP
    {
        public string code { set; get; }
        public float rate_float { set; get; }
    }
}
