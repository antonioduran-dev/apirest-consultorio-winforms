using ConsultorioApp.Controllers;
using DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioApp.Views
{
    public partial class FrmUpdateCitas : Form
    {
        private int? _id;
        private Medico _medico;
        private CitasController _citaController;
        private PacientesController _pacienteController;
        // private MedicosController _medicoController;
        private IEnumerable<Paciente> _pacientes;
        // private IEnumerable<Medico> _medicos;

        public FrmUpdateCitas(Medico medico, int? id = null)
        {
            InitializeComponent();
            _citaController = new CitasController();
            _pacienteController = new PacientesController();
            // _medicoController = new MedicosController();
            _pacientes = new List<Paciente>();
            // _medicos = new List<Medico>();
            _id = id;
            _medico = medico;

            cmbPacientes.SelectedIndex = 0;

            if (_id != null)
                LoadData();
        }

        private void FrmUpdateCitas_Load(object sender, EventArgs e)
        {
            SetPacientesMedicos();
        }

        private async void SetPacientesMedicos()
        {
            _pacientes = await _pacienteController.GetPacientes();
            // _medicos = await _medicoController.GetMedicos();

            if (_pacientes != null)
            {
                foreach (var paciente in _pacientes)
                {
                    cmbPacientes.Items.Add($"{paciente.PacienteId}: " + paciente.Nombre);
                }
                //foreach (var medico in _medicos)
                //{
                //    cmbDoctores.Items.Add($"{medico.MedicoId}: " + medico.Nombre);
                //}
            }
        }

        private async void LoadData()
        {
            Cita cita = await _citaController.GetCita((int)_id!);

            cmbPacientes.SelectedItem = $"{cita.PacienteId}: " + cita.Paciente!.Nombre;
            //cmbDoctores.SelectedItem = $"{cita.MedicoId}: " + cita.Medico!.Nombre;
            dtimePickCita.Value = cita.FechaCita.ToDateTime(TimeOnly.MinValue); // convert DateOnly to DateTime.
            dtimePickHoraCita.Value = cita.FechaCita.ToDateTime(TimeOnly.Parse(cita.HoraCita.ToString()));
            txtbMotivoCita.Text = cita.MotivoCita;
        }

        private async void btnGuardarCita_Click(object sender, EventArgs e)
        {
            string motivoCita = txtbMotivoCita.Text;
            DateOnly fechaCita = DateOnly.FromDateTime(dtimePickCita.Value); // convert datetime to dateonly.
            TimeOnly horaCita = TimeOnly.FromDateTime(dtimePickHoraCita.Value);

            if (cmbPacientes.SelectedIndex != 0)
            {
                // get the IDs from the selected item in combo box.
                int idPaciente = Convert.ToInt32(cmbPacientes.SelectedItem!.ToString()!.Substring(0, 1));
                // int idMedico = Convert.ToInt32(cmbDoctores.SelectedItem!.ToString()!.Substring(0, 1));

                if (_id == null)
                {

                        Cita cita = new Cita()
                        {
                            PacienteId = idPaciente,
                            MedicoId = _medico.MedicoId,
                            FechaCita = fechaCita,
                            HoraCita = horaCita,
                            MotivoCita = motivoCita
                        };

                        await _citaController.AddCita(cita);

                        this.Close();
                }
                else
                {
                        Cita cita = new Cita()
                        {
                            CitaId = (int)_id,
                            PacienteId = idPaciente,
                            MedicoId = _medico.MedicoId,
                            FechaCita = fechaCita,
                            HoraCita = horaCita,
                            MotivoCita = motivoCita
                        };

                        await _citaController.UpdateCita(cita);

                        this.Close();
                }

            }
            else
            {
                MessageBox.Show("Seleccione un Paciente y Médico", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
