namespace ConsoleFactory
{
    public class CocheFactoria : VehiculoFactoria
    {
        public override IVehiculo CrearVehiculo()
        {
            return new Coche();
        }
    }
}
