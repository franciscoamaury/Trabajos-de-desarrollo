namespace Formulario2
{
    public partial class Form1 : Form
    {
        List<persona> dataviewCedula = new List<persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Agregar.Enabled = false;
            Guardar.Enabled = true;
            Cancelar.Enabled = true;
            Datos.Enabled = true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            var persona1 = new persona
            {
                Id = Guid.NewGuid,
                nombre = textNombre.Text,
                numerodecedula = textNocedula.,
                ocupacion = textOcupacion.Text,
                fechadenacimiento = Fechadenacimiento,
                nacionalidad = textNacionalidad.Text,
                estadocivil = textEstadocivil.Text,
                sexo = botonM.Checked ? "M" : "F",
                tipodesangre = textTipo.Text
            };
            dataviewCedula.Add(persona1);
        }  
        
    }
    public class persona
    {
        public Guid Id { get; set; }
        public string nombre { get; set; }
        public int numerodecedula { get; set; }
        public string ocupacion { get; set; }
        public DateTime fechadenacimiento { get; set; }
        public string nacionalidad { get; set; }
        public string estadocivil { get; set; }
        public string sexo { get; set; }
        public string tipodesangre { get; set; }
    }
}