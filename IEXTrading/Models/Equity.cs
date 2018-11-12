using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace IEXTrading.Models
{
    public class ChartRoot
    {
        public Equity[] chart { get; set; }
    }

    public class Equity
    {
        public int EquityId { get; set; }
        public string companyName { get; set; }
        public float peRatio { get; set; }
        public float ytdChange { get; set; }
        public string date { get; set; }
        public float open { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float close { get; set; }
        public int volume { get; set; }
        public int unadjustedVolume { get; set; }
        public float change { get; set; }
        public float changePercent { get; set; }
        public float vwap { get; set; }
        public string label { get; set; }
        public float changeOverTime { get; set; }
        public string symbol { get; set; }
        public float week52High { get; set; }
        public float week52Low { get; set; }
        
    }
}
