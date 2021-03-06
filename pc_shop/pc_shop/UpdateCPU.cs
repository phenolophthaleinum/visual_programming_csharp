﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Text.RegularExpressions;

namespace pc_shop
{
    public partial class UpdateCPU : Form
    {
        public UpdateCPU()
        {
            InitializeComponent();
            string[] model_names = Placeholder.cpu_list.Select(n => n.Name).ToArray();
            this.nameBox.AutoCompleteCustomSource.AddRange(model_names);
            this.nameBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.nameBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(this.nameBox.Text.Length == 0 || this.priceBox.Text.Length == 0)
            {
                SystemSounds.Exclamation.Play();
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Proszę wpisać nazwę procesora i cenę";
                return;
            }
            else
            {
                var price = double.Parse(this.priceBox.Text.Replace('.', ','));
                Placeholder.cpu_list.Add(new CPU(this.nameBox.Text, price));
                this.statusLabel.Image = Placeholder.b_info;
                this.statusLabel.Text = string.Format("Procesor o nazwie {0} został utworzony", this.nameBox.Text);
                this.nameBox.ResetText();
                this.priceBox.ResetText();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.nameBox.Text.Length != 0)
            {
                var model_name = this.nameBox.Text;
                foreach(var cpu in Placeholder.cpu_list)
                {
                    if(cpu.Name == model_name)
                    {
                        Placeholder.cpu_list.Remove(cpu);
                        this.nameBox.AutoCompleteCustomSource.Remove(model_name);
                        this.statusLabel.Image = Placeholder.b_info;
                        this.statusLabel.Text = string.Format("Procesor o nazwie {0} został usunięty", model_name);
                        return;
                    }
                }
                SystemSounds.Exclamation.Play();
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = (string.Format("Procesor o nazwie {0} nie istnieje", model_name));
            }
            else
            {
                SystemSounds.Exclamation.Play();
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Proszę wpisać nazwę procesora do usunięcia";
                return;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(this.priceBox.Text, @"^[0-9]*[.,]?[0-9]*$"))
            {
                return;
            }
            else
            {
                SystemSounds.Exclamation.Play();
                this.statusLabel.Image = Placeholder.b_error;
                this.statusLabel.Text = "Cena może zawierać tylko liczby oraz znak ',' lub '.'";
                return;
            }
        }
    }
}
