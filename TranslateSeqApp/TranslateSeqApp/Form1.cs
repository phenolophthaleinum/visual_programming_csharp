using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslateSeqApp
{
    public partial class Form1 : Form
    {
        string placeholderText = "Podaj tutaj sekwencje w formacie FASTA.";
        string placeholderText2 = "Wynikiem będzie sekwencja aminokwasowa, w której podświetlone" +
            " fragmenty będą oznaczać potencjalne funkcjonalne białka";
        public Form1()
        {
            InitializeComponent();
            this.seqBox.Text = placeholderText;
            this.outputBox.Text = placeholderText2;
            this.seqBox.ForeColor = Color.Gray;
            this.outputBox.ForeColor = Color.Gray;
            this.labelStrip.Text = "Gotowy.";
        }
        private void translateButton_Click(object sender, EventArgs e)
        {
            //System.ServiceModel.EndpointNotFoundException
            this.labelStrip.Text = "Nawiązuję połączenie...";
            TranslateServer.TranslateSeqClient obj = new TranslateServer.TranslateSeqClient();

            try
            {
                string result = obj.Translate(this.seqBox.Text);
                this.outputBox.Text = result.ToString();
                this.highlightProt();
                this.outputBox.ForeColor = Color.Black;
                this.labelStrip.Text = "Translacja przeszła pomyślnie. Gotowy.";
            }
            catch(System.ServiceModel.EndpointNotFoundException)
            {
                this.outputBox.Text = "There was something wrong! Check your input format (FASTA) or check your connection to server.";
                this.labelStrip.Text = "Błąd. Gotowy.";
            }
        }

        private void seqBox_Enter(object sender, EventArgs e)
        {
            if (this.seqBox.Text == placeholderText)
            {
                this.seqBox.Text = "";
                this.seqBox.ForeColor = Color.Black;
            }
        }

        private void seqBox_Leave(object sender, EventArgs e)
        {
            if (this.seqBox.Text == "")
            {
                this.seqBox.Text = placeholderText;
                this.seqBox.ForeColor = Color.Gray;
            }
        }

        private void highlightProt()
        {
            Regex regex = new Regex(@"M\w+");
            MatchCollection matches = regex.Matches(this.outputBox.Text);
            this.outputBox.SelectAll();
            this.outputBox.SelectionBackColor = this.outputBox.BackColor;
            foreach(Match match in matches)
            {
                this.outputBox.Select(match.Index, match.Length);
                this.outputBox.SelectionBackColor = Color.Orange;
            }

        }

        private void outputBox_Enter(object sender, EventArgs e)
        {
            if (this.outputBox.Text == placeholderText2)
            {
                this.outputBox.Text = "";
                this.outputBox.ForeColor = Color.Black;
            }
        }

        private void outputBox_Leave(object sender, EventArgs e)
        {
            if (this.outputBox.Text == "")
            {
                this.outputBox.Text = placeholderText2;
                this.outputBox.ForeColor = Color.Gray;
            }
        }

        private void exampleButton_Click(object sender, EventArgs e)
        {
            this.seqBox.ForeColor = Color.Black;
            this.seqBox.Text = @">FN390863.1:950-1907 Ursus spelaeus complete mitochondrial genome, isolate SP2073
AAAGGTTTGGTCCTGGCCTTCCTATTGGCTATTAACAAGATTACACATGTAAGTCTCCGCGCTCCAGTGAAAATGCCCTT
TGGATCTTAAAGCGATTTGAAGGAGCGGGCATCAAGCACACCTCTCCCCGGTAGCTTATAACGCCTTGCTTAGCCACGCC
CCCACGGGATACAGCAGTGATAAAAATTAAGCTATGAACGAAAGTTCGACTAAGCTATGTTGATTAAGGGTTGGTTAATT
TCGTGCCAGCCACCGCGGTTATACGATTGACCCGAGTTAATAGGCCCACGGCGTAAAGCGTGTGAAAGAAAAAAATTTCC
CTACTAAAGTTAAAGTTTAATCCAGCTGTAAAAAGCTATCAGTAACACTAAAATAAACTACGAAAGTGACTTTAATACTC
TCAACCACACGACAGCTAAGATCCAAACTGGGATTAGATACCCCACTATGCTTAGCCTTAAACATAAGTAATTTATTAAA
CAAAATTATTCGCCAGAGAACTACTAGCAACAGCTTAAAACTCAAAGGACTTGGCGGTGCTTTAAACCCCCTAGAGGAGC
CTGTTCTGTAATCGATAAACCCCGATAGACCTCACCACCTCTTGCTAATCCAGTCTATATACCGCCATCTTCAGCAAACC
CTTAAAAGGAATAAGAGTAAGCACAATCATATCGCATAAAAAAGTTAGGTCAAGGTGTAACCCATGGGGTGGGAAGAAAT
GGGCTACATTTTCTACTCAAGAACAACTTACGAAAGTTTTTATGAAATTAAAAACTAAAGGTGGATTTAGCAGTAAATCA
AGAATAGAGAGCTTGATTGAACAAGGCAATGAAGCATGCACACACCGCCCGTCACCCTCCTCAAGTGGCACAAGCCAAAC
ATAACCTATTGGAACCAAATAAAACGCAAGAGGAGACAAGTCGTAACAAGGTAAGCATACTGGAAAGTGTGCTTGGAT";
        }
    }
}
