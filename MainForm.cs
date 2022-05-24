using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSysSim
{
    public partial class MainForm : Form
    {
        private readonly Simulaator sim;
        private string algoInputString;
        private Bitmap chart;

        public MainForm()
        {
            InitializeComponent();
            sim = new Simulaator();
            algoInputString = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void LoadAlgoInput()
        {
            // Check if custom input is selected & copy input from the textbox
            if (customAlgo.Checked && (CustomAlgoTextbox.Text.Length != 0))
            {
                algoInputString = CustomAlgoTextbox.Text;
            }
            else
            {
                // Find the selected radio button (yes there are many better ways to do this)
                algoInputString = sampleAlgo1.Checked ? sampleAlgo1.Text :
                    (sampleAlgo2.Checked ? sampleAlgo2.Text :
                    (sampleAlgo3.Checked ? sampleAlgo3.Text : ""));
            }
        }

        private void Run()
        {
            Clear();
            LoadAlgoInput();

            if (String.IsNullOrEmpty(algoInputString)) return; // No input was given at all, exit.

            // Display messagebox on error (wrong string format)
            try { sim.LoadFromString(algoInputString); }
            catch (FormatException)
            {
                MessageBox.Show("Vale sisend!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sim.Simuleeri();
            DrawSimulation();
            arvutusedLabel.Text = sim.Arvutus;
        }

        private void DrawSimulation()
        {
            int boxWidth = 20;
            int boxHeight = 24;
            chart = new Bitmap(simChart.Width, simChart.Height);

            using (Graphics gr = Graphics.FromImage(chart))
            using (Brush blackBrush = new SolidBrush(Color.Black))
            using (Font font = new Font("Consolas", 10))
            {
                gr.Clear(SystemColors.Control);
                gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                for (int i = 0, xPos = 80; i < 48; i++, xPos += boxWidth)
                {
                    // Top number row
                    string number = (i+1) + "";
                    SizeF stringSize = gr.MeasureString(number, font);
                    PointF stringLocation = new PointF(xPos + (boxWidth / 2) - (stringSize.Width / 2),
                                                       (boxHeight / 2) - (stringSize.Height / 2) + 1);
                    gr.DrawString(number, font, blackBrush, stringLocation);
                }

                for (int samm = 0, yPos = 30; samm < sim.Sammud.Count; samm++, yPos += boxHeight+10)
                {
                    int xPos = 0;
                    gr.DrawString("Samm " + (samm + 1), font, blackBrush, new PointF(xPos, yPos+4));
                    xPos = 80;

                    List<Fail> sammBlocks = sim.Sammud[samm];

                    for (int j = 0; j < 48; j++, xPos += boxWidth)
                    {
                        Fail sammFail = sammBlocks[j];
                        Rectangle rect = new Rectangle(xPos, yPos, boxWidth, boxHeight);

                        // Processes have letters for names, or "-" if the tick was empty.
                        SizeF stringSize = gr.MeasureString("A", font);
                        PointF stringLocation = new PointF(xPos + (boxWidth / 2) - (stringSize.Width / 2),
                                                           yPos + (boxHeight / 2) - (stringSize.Height / 2) + 1);

                        gr.FillRectangle(new SolidBrush(sammFail.Color), rect);
                        using (Pen selPen = new Pen(Color.Black))
                        {
                            gr.DrawRectangle(selPen, rect);
                        }
                        gr.DrawString(sammFail.Nimi, font, blackBrush, stringLocation);
                    }

                    // Check if there was not enough memory left (name "x"), draw extra text on top
                    if (!sammBlocks[0].OnNull && sammBlocks[0].Nimi.Equals("x"))
                    {
                        string text = "Uue faili jaoks ei jätku ruumi";
                        SizeF stringSize = gr.MeasureString(text, font);
                        PointF stringLocation = new PointF((boxWidth * 56 / 2) - (stringSize.Width / 2),
                                                           yPos + (boxHeight / 2) - (stringSize.Height / 2) + 1);
                        gr.DrawString(text, font, new SolidBrush(Color.White), stringLocation);
                    }
                }
            }

            simChart.Image = chart;
        }

        private void Clear()
        {
            sim.Clear();
            simChart.Image = null;
            arvutusedLabel.Text = "";
            GC.Collect();
        }

        private void RunButton_Click(object sender, EventArgs e) { Run(); }
        private void ClearButton_Click(object sender, EventArgs e) { Clear(); }

        // Switch to the "custom algorithm" option automatically when selecting its input textbox
        private void CustomAlgoTextbox_TextChanged(object sender, EventArgs e) { customAlgo.Checked = true; }
        private void CustomAlgoTextbox_Click(object sender, EventArgs e) { customAlgo.Checked = true; }
        private void CustomAlgoTextbox_Enter(object sender, EventArgs e) { customAlgo.Checked = true; }
    }
}
