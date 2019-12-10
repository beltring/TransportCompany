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

            string name = addForm.nameTextBox.Text;
            double cost = Convert.ToDouble(addForm.costTextBox.Text);
            double weight = Convert.ToDouble(addForm.weightTextBox.Text);
            double volume = Convert.ToDouble(addForm.volumeTextBox.Text);
            string uploadDate = addForm.uploadDateTextBox.Text;
            string trailerType = addForm.trailerTypeComboBox.SelectedItem.ToString();
            string status = addForm.statusComboBox.SelectedItem.ToString();
            string downloadLocation = addForm.loadLocationTextBox.Text;
            string placeOfDischarge = addForm.placeOfDischargeTextBox.Text;
            int distance = Convert.ToInt32(addForm.distanceTextBox.Text);


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