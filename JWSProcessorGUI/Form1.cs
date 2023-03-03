using JWSLib;

namespace JWSProcessorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "JWSProcessorGUI";
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var file in FileList.Items)
            {
                var jwsFile = new JWSFile((string)file);
                jwsFile.ExportToCSV(DestinationFolderBox.Text);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (FileList.SelectedIndex != -1)
            {
                for (int i = FileList.SelectedItems.Count - 1; i >= 0; i--)
                {
                    FileList.Items.Remove(FileList.SelectedItems[i]);
                }
            }

        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {

            using var dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter = "Jasco CD Spectrometer Files (*.jws)|*.jws|Jasco CD Spectrometer Files (*.jwb)|*.jwb|Any File (*.*)|*.*";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileList.Items.AddRange(dialog.FileNames);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            using var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                DestinationFolderBox.Text = dialog.SelectedPath;
            }

        }

    }
}