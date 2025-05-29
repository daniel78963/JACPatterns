using ConsoleFactory;

VehiculoFactoria cocheFactory = new CocheFactoria();
IVehiculo coche = cocheFactory.CrearVehiculo();
coche.Conducir();

VehiculoFactoria bicisFactory = new BicicletaFactoria();
IVehiculo bici = bicisFactory.CrearVehiculo();
bici.Conducir();