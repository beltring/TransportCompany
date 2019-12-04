using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Util
{
    class Initializer
    {
        public static Cargo InitCargoWithAddForm(AddForm addForm)
        {
            Cargo cargo = null;

            string name = addForm.NameTextBox.Text;
            double cost = Convert.ToDouble(addForm.CostTextBox.Text);
            double weight = Convert.ToDouble(addForm.WeightTextBox.Text);
            double volume = Convert.ToDouble(addForm.VolumeTextBox.Text);
            string uploadDate = addForm.UploadDateTextBox.Text;
            string trailerType = addForm.TrailerTypeComboBox.SelectedItem.ToString();
            string status = addForm.StatusComboBox.SelectedItem.ToString();
            string downloadLocation = addForm.LoadLocationTextBox.Text;
            string placeOfDischarge = addForm.PlaceOfDischargeTextBox.Text;
            int distance = Convert.ToInt32(addForm.DistanceTextBox.Text);


            cargo = new Cargo
            {
                Name = name,
                Cost = cost,
                Weight = weight,
                Volume = volume,
                UploadDate = DateTime.Parse(uploadDate),
                TrailerType = trailerType,
                Status = status,
                DownloadLocation = downloadLocation,
                PlaceOfDischarge = placeOfDischarge,
                Distance = distance
            };
            return cargo;
        }
    }
}
