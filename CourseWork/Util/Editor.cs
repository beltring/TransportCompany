using CourseWork.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Util
{
    class Editor
    {
        public void OpenFieldsInEditForm(ref EditForm editForm)
        {
            editForm.nameTextBox.ReadOnly = false;
            editForm.costTextBox.ReadOnly = false;
            editForm.weightTextBox.ReadOnly = false;
            editForm.volumeTextBox.ReadOnly = false;
            editForm.uploadDateTextBox.ReadOnly = false;
            editForm.loadLocationTextBox.ReadOnly = false;
            editForm.placeOfDischargeTextBox.ReadOnly = false;
            editForm.distanceTextBox.ReadOnly = false;
            editForm.editCargoButton.Enabled = true;
        }
    }
}
