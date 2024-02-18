using HtmlAgilityPack;
using System;
using System.Net;
using System.Threading.Tasks;

namespace WebSiteInfoApp
{
    public partial class F_MainApp : DevExpress.XtraEditors.XtraForm
    {
        public F_MainApp()
        {
            InitializeComponent();
        }

        private async void BTNsearch_Click(object sender, EventArgs e)
        {
            string url = TXTttargetUrl.Text;
            if (string.IsNullOrEmpty(url))
            {
                return;
            }

            if (!IsUrlValid(url)) return;


            splashScreenManager1.ShowWaitForm();
            txtresult.Clear();

            await Task.Run(() =>
            {
                string htmlCode;

                using (WebClient client = new WebClient())
                {
                    htmlCode = client.DownloadString(url);
                }

                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load(url);

                HtmlNodeCollection metaTags = document.DocumentNode.SelectNodes("//meta[@name='keywords']");

                if (metaTags != null && metaTags.Count > 0)
                {
                    string keywords = metaTags[0].GetAttributeValue("content", "");
                    txtresult.Invoke((Action)(() => txtresult.Text = keywords));
                }
                else
                {
                    txtresult.Invoke((Action)(() => txtresult.Text = "Üzgünüm, Malesef Sonuç Bulamadım.."));
                }

            });

            splashScreenManager1.CloseWaitForm();
        }

        private void F_MainApp_Load(object sender, EventArgs e)
        {

        }


        static bool IsUrlValid(string input)
        {
            return Uri.TryCreate(input, UriKind.Absolute, out Uri result) &&
                   (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
        }

    }
}
