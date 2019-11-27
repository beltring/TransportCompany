using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseWork.Context
{
    public class CargosDB
    {
        public static void Select(DataGridView dataGridView1)
        {
            try
            {
                using (CourseWork.TransportCompanyContext db = new CourseWork.TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (var cargo in cargos)
                    {
                        dataGridView1.Rows.Add(new string[] {
                            Convert.ToString(cargo.Id),
                            cargo.Name,
                            Convert.ToString(cargo.Cost),
                            Convert.ToString(cargo.Weight),
                            Convert.ToString(cargo.Volume),
                            cargo.TrailerType,
                            cargo.UploadDate.ToString(),
                            cargo.Status,
                            cargo.DownloadLocation,
                            cargo.PlaceOfDischarge,
                            Convert.ToString(cargo.Distance)

                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string SelectAllDetailed(int id)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (var cargo in cargos)
                    {
                        result.Append(Convert.ToString("Название:" + cargo.Name + "\n" + "Стоимость:" + cargo.Cost + "\n"
                                                    + "Вес:" + cargo.Weight + "\n" + "Объём:" + cargo.Volume + "\n" + "Тип кузова:" +
                                                    cargo.TrailerType + "\n" + "Дата загрузки:" + cargo.UploadDate + "\n" + "Статус заказа:" +
                                                    cargo.Status + "\n" + "Место загрузки:" + cargo.DownloadLocation + "\n" + "Место разгрузки:" +
                                                    cargo.PlaceOfDischarge + "\n" + "Расстояние:" + cargo.Distance));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result.ToString();
        }

        public static void UpdateStatus(string status, int id)
        {
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (var cargo in cargos)
                    {
                        if(cargo.Id == id)
                        {
                            cargo.Status = status;
                        }
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SelectFavourites(DataGridView dataGridView1, int[] id)
        {
            dataGridView1.Update();

            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (int element in id)
                    {
                        foreach (var cargo in cargos)
                        {
                            if (cargo.Id == element)
                            {
                                dataGridView1.Rows.Add(new string[] {
                                    Convert.ToString(cargo.Id),
                                    cargo.Name,
                                    Convert.ToString(cargo.Cost),
                                    Convert.ToString(cargo.Weight),
                                    Convert.ToString(cargo.Volume),
                                    cargo.TrailerType,
                                    cargo.UploadDate.ToString(),
                                    cargo.Status,
                                    cargo.DownloadLocation,
                                    cargo.PlaceOfDischarge,
                                    Convert.ToString(cargo.Distance)
                                });
                                break;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        public static bool AddCargo(Cargo cargo)
        {
            try
            {
                DataValidation dataValidation = new DataValidation();

                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    if (dataValidation.CheckEmptyFields(cargo.Name, cargo.UploadDate.ToString(), cargo.TrailerType, cargo.Status, cargo.DownloadLocation, 
                        cargo.PlaceOfDischarge) && dataValidation.CheckCost(cargo.Cost) && dataValidation.CheckDistance(cargo.Distance) && 
                        dataValidation.CheckVolume(cargo.Volume) && dataValidation.CheckWeight(cargo.Weight))
                    {
                        db.Cargos.Add(cargo);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DeleteCargo(int id)
        {
            try // обработчик ошибок
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    if(id > 0)
                    {
                        var cargos = db.Cargos.ToList();
                        foreach (var cargo in cargos)
                        {
                            if (id > 0 && cargo.Id == id)
                            {
                                db.Cargos.Remove(cargo);
                                
                            }
                        }

                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
