using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace CryptoData
{
    class Program
    {
        private static readonly string CRYPTO_API_KEY = "<api_key>";
        private static readonly string STOCKS_API_KEY = "<api_key>";

        public static void Main(string[] args)
        {
            try
            {
                CryptoCoins cc = ParseCryptoResponse(GetCryptoData());
                UploadDataToExcel(cc);

                StocksData sd = ParseStockResponse(GetStocksData("HAL"));
                UploadDataToExcel(sd);
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static string GetCryptoData()
        {
            string url = "https://min-api.cryptocompare.com/data/pricemulti?fsyms=ETH,XRP,XLM,OXT,EOS,ZRX,BAT,DAI,XTZ,BNB,BTT,WINK,TRX,ADA&tsyms=USD&api_key=";

            // ETH,XRP,XLM,OXT,EOS,ZRX,BAT,DAI,XTZ,BNB,BTT,WINK,TRX,ADA

            using (HttpClient httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri(url + CRYPTO_API_KEY)).Result;

                return response;
            }
        }

        static CryptoCoins ParseCryptoResponse(string response)
        {
            return JToken.Parse(response).ToObject<CryptoCoins>();

            // for debugging
            //CryptoCoins parsedResponse = JToken.Parse(response).ToObject<CryptoCoins>();
            //return parsedResponse;
        }

        static string GetStocksData(string ticker)
        {
            string url = $"https://cloud.iexapis.com/stable/stock/{ticker}/quote?token=";

            using (HttpClient httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri(url + STOCKS_API_KEY)).Result;

                return response;
            }
        }

        static StocksData ParseStockResponse(string response)
        {
            //return JToken.Parse(response).ToObject<StocksData>();

            // for debugging
            StocksData parsedResponse = JToken.Parse(response).ToObject<StocksData>();
            return parsedResponse;
        }

        static void UploadDataToExcel(CryptoCoins cc)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string excelFilePath = @"<filePath>";
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(excelFilePath), "password"))
            {
                ExcelWorkbook excelWorkbook = excelPackage.Workbook;
                ExcelWorksheet excelWorksheet = excelWorkbook.Worksheets["Sheet1"];
                excelWorksheet.Cells["C2"].Value = cc.ETH.USD;
                excelWorksheet.Cells["C3"].Value = cc.XRP.USD;
                excelWorksheet.Cells["C4"].Value = cc.XLM.USD;
                excelWorksheet.Cells["C5"].Value = cc.OXT.USD;
                excelWorksheet.Cells["C6"].Value = cc.EOS.USD;
                excelWorksheet.Cells["C7"].Value = cc.ZRX.USD;
                excelWorksheet.Cells["C8"].Value = cc.BAT.USD;
                excelWorksheet.Cells["C9"].Value = cc.DAI.USD;
                excelWorksheet.Cells["C10"].Value = cc.XTZ.USD;
                excelWorksheet.Cells["C11"].Value = cc.BNB.USD;
                excelWorksheet.Cells["C12"].Value = cc.BTT.USD;
                //excelWorksheet.Cells["C13"].Value = cc.WINK.USD;  //no call available currently. WINK is pretty well worthless anyway...
                excelWorksheet.Cells["C14"].Value = cc.TRX.USD;
                excelWorksheet.Cells["C15"].Value = cc.ADA.USD;

                excelWorksheet.Cells["B19"].Value = DateTime.Now.ToString("MM/dd/yy");

                excelPackage.Save();
            }
        }

        static void UploadDataToExcel(StocksData sd)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string excelFilePath = @"C:\Users\JW33\Documents\Budget1.xlsx";
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(excelFilePath), "password"))
            {
                ExcelWorkbook excelWorkbook = excelPackage.Workbook;
                ExcelWorksheet excelWorksheet = excelWorkbook.Worksheets["Sheet2"];
                excelWorksheet.Cells["B17"].Value = sd.latestPrice;

                excelWorksheet.Cells["B18"].Value = DateTime.Now.ToString("MM/dd/yy");

                excelPackage.Save();
            }
        }
    }
}
