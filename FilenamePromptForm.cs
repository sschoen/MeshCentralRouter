﻿/*
Copyright 2009-2021 Intel Corporation

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Windows.Forms;

namespace MeshCentralRouter
{
    public partial class FilenamePromptForm : Form
    {
        public string filename
        {
            get { return mainTextBox.Text; }
            set { mainTextBox.Text = value; }
        }

        public FilenamePromptForm(string operation, string filename)
        {
            InitializeComponent();
            Translate.TranslateControl(this);
            mainGroupBox.Text = operation;
            mainTextBox.Text = filename;
            okButton.Enabled = (filename.Length > 0);
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = (mainTextBox.Text.Length > 0);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
