using LinqLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = ListManager.LoadSampleData();
        public Dashboard()
        {
            InitializeComponent();
            InitializeBinding();
        }
        private void InitializeBinding()
        {
            allPeopleDropdown.DataSource = people;
            allPeopleDropdown.DisplayMember = "FullName";

            filteredPeopleList.DataSource = people
                .Where(x => x.YearExperience >= 5)
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .ToList();
            filteredPeopleList.DisplayMember = "FullName";
        }
        private void UpdateBindings()
        {
            filteredPeopleList.DataSource = people
                .Where(x => x.YearExperience >= 5)
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .ToList();
        }

        private void allPeopleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)allPeopleDropdown.SelectedItem;

            yearsExperiencePicker.Value = selectedPerson.YearExperience;
        }

        private void updatePersonButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)allPeopleDropdown.SelectedItem;

            selectedPerson.YearExperience = Convert.ToInt32(yearsExperiencePicker.Value);

            UpdateBindings();
        }
    }
}
