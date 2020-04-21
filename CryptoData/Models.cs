using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoData
{
    public class Models
    {
    }

    public class ETH
    {
        public double USD { get; set; }
    }

    public class XRP
    {
        public double USD { get; set; }
    }

    public class XLM
    {
        public double USD { get; set; }
    }

    public class OXT
    {
        public double USD { get; set; }
    }

    public class EOS
    {
        public double USD { get; set; }
    }

    public class ZRX
    {
        public double USD { get; set; }
    }

    public class BAT
    {
        public double USD { get; set; }
    }

    public class DAI
    {
        public double USD { get; set; }
    }

    public class XTZ
    {
        public double USD { get; set; }
    }

    public class BNB
    {
        public double USD { get; set; }
    }

    public class BTT
    {
        public double USD { get; set; }
    }

    public class TRX
    {
        public double USD { get; set; }
    }

    public class ADA
    {
        public double USD { get; set; }
    }

    public class CryptoCoins
    {
        public ETH ETH { get; set; }
        public XRP XRP { get; set; }
        public XLM XLM { get; set; }
        public OXT OXT { get; set; }
        public EOS EOS { get; set; }
        public ZRX ZRX { get; set; }
        public BAT BAT { get; set; }
        public DAI DAI { get; set; }
        public XTZ XTZ { get; set; }
        public BNB BNB { get; set; }
        public BTT BTT { get; set; }
        public TRX TRX { get; set; }
        public ADA ADA { get; set; }
    }

    public class StocksData
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string primaryExchange { get; set; }
        public string calculationPrice { get; set; }
        public object open { get; set; }
        public object openTime { get; set; }
        public string openSource { get; set; }
        public object close { get; set; }
        public object closeTime { get; set; }
        public string closeSource { get; set; }
        public object high { get; set; }
        public long highTime { get; set; }
        public string highSource { get; set; }
        public object low { get; set; }
        public long lowTime { get; set; }
        public string lowSource { get; set; }
        public double latestPrice { get; set; }
        public string latestSource { get; set; }
        public string latestTime { get; set; }
        public long latestUpdate { get; set; }
        public object latestVolume { get; set; }
        public double iexRealtimePrice { get; set; }
        public int iexRealtimeSize { get; set; }
        public long iexLastUpdated { get; set; }
        public object delayedPrice { get; set; }
        public object delayedPriceTime { get; set; }
        public object oddLotDelayedPrice { get; set; }
        public object oddLotDelayedPriceTime { get; set; }
        public object extendedPrice { get; set; }
        public object extendedChange { get; set; }
        public object extendedChangePercent { get; set; }
        public object extendedPriceTime { get; set; }
        public double previousClose { get; set; }
        public int previousVolume { get; set; }
        public int change { get; set; }
        public double changePercent { get; set; }
        public object volume { get; set; }
        public double iexMarketPercent { get; set; }
        public int iexVolume { get; set; }
        public int avgTotalVolume { get; set; }
        public int iexBidPrice { get; set; }
        public int iexBidSize { get; set; }
        public int iexAskPrice { get; set; }
        public int iexAskSize { get; set; }
        public object iexOpen { get; set; }
        public object iexOpenTime { get; set; }
        public double iexClose { get; set; }
        public long iexCloseTime { get; set; }
        public long marketCap { get; set; }
        public double peRatio { get; set; }
        public double week52High { get; set; }
        public double week52Low { get; set; }
        public double ytdChange { get; set; }
        public long lastTradeTime { get; set; }
        public bool isUSMarketOpen { get; set; }
    }
}
