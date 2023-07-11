
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Bypass SSL certificate validation
                System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                string url = "https://chapmanganato.com/manga-dg980989/chapter-1"; // Replace with the actual URL you want to retrieve data from

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Error: " + ex.Message);

                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
            }
        }


