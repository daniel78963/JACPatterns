namespace ConsoleFactory
{
    public class BicicletaFactoria : VehiculoFactoria
    {
        public override IVehiculo CrearVehiculo()
        {
            return new Bicicleta();
        }
    }
}
