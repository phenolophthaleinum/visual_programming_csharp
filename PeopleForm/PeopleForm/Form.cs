using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleForm
{
    public partial class MainForm : Form
    {
        private List<Person> list = new List<Person>();
        private int person_index = 0;

        public MainForm()
        {
            InitializeComponent();
            this.populateYearCombobox();
            this.loadSession();
            this.statusLabel.Text = "Gotowy";
            this.FormClosing += Form_FormClosing;
        }

        private void getPersonData(Person new_person)
        {
            this.nameRichBox.Text = new_person.name;
            this.last_nameRichBox.Text = new_person.last_name;
            this.positionCombo.SelectedItem = new_person.position.ToString();
            if(new_person.sex == "woman")
            {
                this.womanRadio.Checked = true;
            }
            else
            {
                this.manRadio.Checked = true;
            }
            this.birthCombo.SelectedItem = new_person.birth;
        }

        private void clearPersonData()
        {
            this.nameRichBox.Clear();
            this.last_nameRichBox.Clear();
            this.positionCombo.SelectedItem = null;
            this.womanRadio.Checked = false;
            this.manRadio.Checked = false;
            this.birthCombo.SelectedItem = null;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            string what_sex = "";

            if (womanRadio.Checked && !manRadio.Checked)
            {
                what_sex = "woman";
            }
            else if(!womanRadio.Checked && manRadio.Checked)
            {
                what_sex = "man";
            }

                Person new_person = new Person(
                    this.nameRichBox.Text,
                    this.last_nameRichBox.Text,
                    this.positionCombo.SelectedItem.ToString(),
                    what_sex,
                    this.birthCombo.SelectedItem.ToString()
                );

                this.list.Add(new_person);
                Console.WriteLine(list);
                this.statusLabel.Text = "Osoba utworzona. Gotowy";
            //this.clearPersonData();

            //Person new_person = new Person();
            //new_person.name = nameRichBox.Text;
        }

        private void populateYearCombobox()
        {
            for(int i = 1900; i < DateTime.Now.Year; ++i)
            {
                birthCombo.Items.Add(i);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.person_index++;
                this.getPersonData(this.list[this.person_index]);
            }
            catch(Exception)
            {
                this.person_index--;
                return;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.person_index == 0)
                {
                    this.list.RemoveAt(this.person_index);
                    clearPersonData();
                }
                else
                {
                    this.list.RemoveAt(this.person_index--);
                    this.getPersonData(this.list[this.person_index]);
                }
                this.statusLabel.Text = "Osoba usunięta. Gotowy";
            }
            catch(Exception)
            {
                this.statusLabel.Text = "Błąd usuwania osoby. Gotowy";
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if(this.person_index == 0)
            {
                return;
            }
            else
            {
                //this.person_index--;
                //this.clearPersonData();
                try
                {
                    this.getPersonData(this.list[--this.person_index]);
                }
                catch
                {
                    return;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.list[this.person_index].name = this.nameRichBox.Text;
                this.list[this.person_index].last_name = this.last_nameRichBox.Text;
                this.list[this.person_index].position = this.positionCombo.SelectedItem.ToString();
                if (womanRadio.Checked && !manRadio.Checked)
                {
                    this.list[this.person_index].sex = "woman";
                }
                else if (!womanRadio.Checked && manRadio.Checked)
                {
                    this.list[this.person_index].sex = "man";
                }
                this.list[this.person_index].birth = (int)this.birthCombo.SelectedItem;
            }
            catch(Exception)
            {
                return;
            }

            this.statusLabel.Text = "Dane osoby zaaktualizowane. Gotowy";
        }

        private void saveSession()
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = Path.Combine(directory, "osoby.bin");

                try
                {
                    Console.WriteLine(this.list.Count);
                    if (this.list.Count == 0)
                    {
                        return;
                    }

                    using (Stream stream = File.Open(file, FileMode.Create))
                    {
                        var format_binary = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        format_binary.Serialize(stream, this.list);
                    }
                }
                catch
                {
                    MessageBox.Show("Error saving session!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("File saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
        }

        private void saveSession_Dialog()
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = Path.Combine(directory);

            SaveFileDialog f = new SaveFileDialog();
            f.InitialDirectory = file;
            f.FileName = "osoby.bin";
            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Console.WriteLine(this.list.Count);
                    if (this.list.Count == 0)
                    {
                        return;
                    }

                    using (Stream stream = File.Open(file + "\\" + "osoby.bin", FileMode.Create))
                    {
                        var format_binary = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        format_binary.Serialize(stream, this.list);
                    }
                }
                catch
                {
                    MessageBox.Show("Error saving session!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("File saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void loadSession()
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = Path.Combine(directory, "osoby.bin");

            if(!new FileInfo(file).Exists)
            {
                return;
            }

            try
            {
                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    var format_binary = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    this.list = (List<Person>)format_binary.Deserialize(stream);
                    if(this.list.Count == 0)
                    {
                        return;
                    }
                }

                MessageBox.Show("Session file loaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.getPersonData(this.list[this.person_index]);
            }
            catch
            {
                MessageBox.Show("Error loading session!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            this.saveSession_Dialog();
        }


        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.saveSession();
        }
    }
}
