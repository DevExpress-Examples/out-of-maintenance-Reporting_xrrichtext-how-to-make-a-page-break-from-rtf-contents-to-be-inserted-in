using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraReports.UI;
namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            RichEditDocumentServer server = new RichEditDocumentServer();
            server.LoadDocument("fish.rtf");
            DocumentRange[] ranges = server.Document.FindAll(DevExpress.Office.Characters.PageBreak.ToString(), DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
            DocumentPosition dp = server.Document.Paragraphs[0].Range.Start;
            
            List<MyRtfObject> collection = new List<MyRtfObject>();
            foreach(DocumentRange dr in ranges) {
                DocumentRange tmpRange = server.Document.CreateRange(dp, dr.Start.ToInt() - dp.ToInt());
                collection.Add(new MyRtfObject() { RtfSplitContent = server.Document.GetRtfText(tmpRange) });
                dp = dr.End;
            }
            DocumentRange tmpRange2 = server.Document.CreateRange(dp, server.Document.Paragraphs[server.Document.Paragraphs.Count-1].Range.End.ToInt() - dp.ToInt());
            collection.Add(new MyRtfObject() { RtfSplitContent = server.Document.GetRtfText(tmpRange2) });

            XtraReport1 report = new XtraReport1();
            report.DataSource = collection;
            report.ShowPreviewDialog();
        }
    }

    public class MyRtfObject {
        public string RtfSplitContent { get; set; }
    }
}
