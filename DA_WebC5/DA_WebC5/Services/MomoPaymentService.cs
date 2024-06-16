using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DA_WebC5
{
    public class MomoPaymentService
    {
        private readonly string _partnerCode = "YourPartnerCode";
        private readonly string _accessKey = "YourAccessKey";
        private readonly string _secretKey = "YourSecretKey";
        private readonly string _endpoint = "https://test-payment.momo.vn/v2/gateway/api/create";

        public async Task<string> CreatePaymentRequest(string orderId, string orderInfo, long amount, string returnUrl, string notifyUrl)
        {
            string requestId = Guid.NewGuid().ToString();
            string requestType = "captureWallet";
            string extraData = "";

            // Raw hash string
            string rawHash = $"accessKey={_accessKey}&amount={amount}&extraData={extraData}&ipnUrl={notifyUrl}&orderId={orderId}&orderInfo={orderInfo}&partnerCode={_partnerCode}&redirectUrl={returnUrl}&requestId={requestId}&requestType={requestType}";

            // Create signature
            string signature = GenerateSignature(rawHash);

            var paymentRequest = new
            {
                partnerCode = _partnerCode,
                accessKey = _accessKey,
                requestId = requestId,
                amount = amount.ToString(),
                orderId = orderId,
                orderInfo = orderInfo,
                redirectUrl = returnUrl,
                ipnUrl = notifyUrl,
                extraData = extraData,
                requestType = requestType,
                signature = signature,
                lang = "en"
            };

            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(paymentRequest), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(_endpoint, content);
                string responseContent = await response.Content.ReadAsStringAsync();
                dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);
                return jsonResponse.payUrl;
            }
        }

        private string GenerateSignature(string rawData)
        {
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_secretKey)))
            {
                byte[] hashValue = hmac.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                return BitConverter.ToString(hashValue).Replace("-", "").ToLower();
            }
        }
    }

}
